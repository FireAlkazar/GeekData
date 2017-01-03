using System.Collections.Generic;
using Contracts.Github;
using Core;
using Github.Crawler.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Nelibur.ObjectMapper;

namespace Github.Crawler
{
    public sealed class GithubRepository : Repository
    {
        public GithubRepository(ConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public List<GithubRepositoryInfo> GetAllByTag(string tag)
        {
            return GetCollection<RepositoryInfoEntity>(MongoCollection.GithubRepositories)
                .FindAsync(x => x.Tags.Contains(tag))
                .Result
                .ToList()
                .ConvertAll(x => TinyMapper.Map<GithubRepositoryInfo>(x));
        }

        public void Save(GithubRepositoryInfo value)
        {
            var entity = TinyMapper.Map<RepositoryInfoEntity>(value);
            entity.Id = ObjectId.GenerateNewId();
            if (!string.IsNullOrWhiteSpace(value.Tag))
            {
                entity.Tags.Add(value.Tag.Trim());
            }
            entity.Description = RemoveSeparator(entity.Description);
            GetCollection<RepositoryInfoEntity>(MongoCollection.GithubRepositories)
                .InsertOneAsync(entity)
                .Wait();
        }
    }
}
