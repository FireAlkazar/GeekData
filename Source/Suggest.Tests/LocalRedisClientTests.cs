using System.Collections.Generic;
using Suggest.Client;
using UnitTests.ClassFixtures;
using Xunit;

namespace Suggest.Tests
{
    public sealed class LocalRedisClientTests : IClassFixture<RedisServerStarter>
    {
        private readonly LocalRedisClient _localRedisClient;

        public LocalRedisClientTests()
        {
            _localRedisClient = new LocalRedisClient();
            _localRedisClient.ClearSuggestions();
        }

        [Fact]
        public void GetWords_WordsList_Ok()
        {
            var wordsList = new List<string> { "a", "aa", "aaa$" };
            _localRedisClient.PublishWords(wordsList);
            var prefix = "a";
            
            List<string> wordsByPrefix = _localRedisClient.GetWordsByPrefix(prefix);

            Assert.True(wordsByPrefix.Count == 1);
            Assert.True(wordsByPrefix.Contains("aaa$"));
        }

        [Fact]
        public void PublishWords_WordNGram_DoesNotThrow()
        {
            var ngrammedWord = new List<string> { "r", "re", "red", "redi", "redis$" };

            _localRedisClient.PublishWords(ngrammedWord);
        }

        [Fact]
        public void GetWords_RedisWord_Ok()
        {
            var wordsList = new List<string> { "r", "re", "red", "redi", "redis$" };
            _localRedisClient.PublishWords(wordsList);

            List<string> resultWords = _localRedisClient.GetWordsByPrefix("redi");

            Assert.True(resultWords.Contains("redis$"));
        }
    }
}
