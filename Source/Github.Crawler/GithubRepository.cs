﻿using Contracts.Github;
using Core;
using Github.Crawler.Entities;
using MongoDB.Bson;
using Nelibur.ObjectMapper;

namespace Github.Crawler
{
    public sealed class GithubRepository : Repository
    {
        private const string CollectionName = "GithubRepositories";

        public GithubRepository(ConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public void Save(GithubRepositoryInfo value)
        {
            var entity = TinyMapper.Map<RepositoryInfoEntity>(value);
            entity.Id = ObjectId.GenerateNewId();
            GetCollection<RepositoryInfoEntity>(CollectionName).InsertOneAsync(entity).Wait();
        }
    }
}
