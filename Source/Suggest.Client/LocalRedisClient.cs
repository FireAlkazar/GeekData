using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;

namespace Suggest.Client
{
    public sealed class LocalRedisClient
    {
        private const string SuggestSortedSetKey = "Suggest";
        private static readonly ConnectionMultiplexer _redis;

        static LocalRedisClient()
        {
            var config = new ConfigurationOptions
            {
                AllowAdmin = true,
                EndPoints = { { "localhost", 6379 } },
                AbortOnConnectFail = false,
                SyncTimeout = (int)TimeSpan.FromSeconds(5).TotalMilliseconds
            };

            _redis = ConnectionMultiplexer.Connect(config);
        }

        public void ClearSuggestions()
        {
            _redis
                .GetDatabase()
                .KeyDelete(SuggestSortedSetKey);
        }

        public List<string> GetWordsByPrefix(string prefix)
        {
            if (string.IsNullOrWhiteSpace(prefix))
            {
                throw new ArgumentNullException(nameof(prefix));
            }

            IDatabase database = _redis.GetDatabase();
            long? entryScore = database.SortedSetRank(SuggestSortedSetKey, prefix);

            RedisValue[] entries = database.SortedSetRangeByRank(SuggestSortedSetKey, entryScore ?? 0);
            return entries
                .ToList()
                .ConvertAll(x => (string)x)
                .Where(x => x.StartsWith(prefix))
                .Where(x => x.EndsWith("$"))
                .ToList();
        }

        public void PublishWords(List<string> ngrammedWord)
        {
            IDatabase database = _redis.GetDatabase();
            ngrammedWord.ForEach(x => database.SortedSetAdd(SuggestSortedSetKey, x, 0));
        }
    }
}
