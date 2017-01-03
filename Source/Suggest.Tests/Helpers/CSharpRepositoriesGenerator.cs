using System.Collections.Generic;
using Contracts.Github;
using Github.Crawler;
using Suggest.Client;

namespace Suggest.Tests.Helpers
{
    public sealed class CSharpRepositoriesGenerator
    {
        private readonly GithubRepository _githubRepository;
        private readonly LocalRedisClient _localRedisClient;

        public CSharpRepositoriesGenerator(
            LocalRedisClient localRedisClient,
            GithubRepository githubRepository)
        {
            _localRedisClient = localRedisClient;
            _githubRepository = githubRepository;
        }

        public void Generate()
        {
            List<GithubRepositoryInfo> infos = _githubRepository.GetAllByTag("C#");

            foreach (GithubRepositoryInfo info in infos)
            {
                InsertInfo(info);
            }
        }

        private static List<string> GetNGrammedWord(string value)
        {
            var result = new List<string>();

            for (var i = 1; i < value.Length; i++)
            {
                result.Add(value.Substring(0, i));
            }

            result.Add(value + "$");

            return result;
        }

        private void InsertInfo(GithubRepositoryInfo info)
        {
            List<string> nGrammedWord = GetNGrammedWord(info.Name);
            _localRedisClient.PublishWords(nGrammedWord);
        }
    }
}
