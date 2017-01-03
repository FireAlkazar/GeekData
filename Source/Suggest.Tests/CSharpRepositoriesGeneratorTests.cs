using System.Collections.Generic;
using Core;
using Github.Crawler;
using Suggest.Client;
using Suggest.Tests.Helpers;
using UnitTests.ClassFixtures;
using Xunit;
using Xunit.Abstractions;

namespace Suggest.Tests
{
    public sealed class CSharpRepositoriesGeneratorTests : IClassFixture<RedisServerStarter>
    {
        private readonly GithubRepository _githubRepository;
        private readonly LocalRedisClient _localRedisClient;
        private readonly ITestOutputHelper _output;

        public CSharpRepositoriesGeneratorTests(ITestOutputHelper output)
        {
            _output = output;
            _localRedisClient = new LocalRedisClient();
            _githubRepository = new GithubRepository(new ConnectionFactory("mongodb://localhost:27017", "GeekData"));

            _localRedisClient.ClearSuggestions();
            var generator = new CSharpRepositoriesGenerator(_localRedisClient, _githubRepository);

            generator.Generate();
        }

        public static List<object[]> AllLetters
        {
            get
            {
                int firstCharIndex = 'a';
                int lastCharIndex = 'z';

                var result = new List<string>();

                for (int i = firstCharIndex; i <= lastCharIndex; i++)
                {
                    var currentChar = (char)i;
                    result.Add(currentChar.ToString());
                }

                return result
                    .ConvertAll(x => new object[] { x });
            }
        }

        [Theory]
        [MemberData("AllLetters")]
        public void GetWordsByPrefix_Prefix_Ok(string prefix)
        {
            List<string> wordsByPrefix = _localRedisClient.GetWordsByPrefix(prefix);

            wordsByPrefix.ForEach(x => _output.WriteLine(x));
        }
    }
}
