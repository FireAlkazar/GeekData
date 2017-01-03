using System;
using RedisInside;

namespace UnitTests.ClassFixtures
{
    public class RedisServerStarter : IDisposable
    {
        private const int DefaultRedisPort = 6379;
        private readonly Redis _redisServer;

        public RedisServerStarter()
        {
            _redisServer = new Redis(x => x.Port(DefaultRedisPort));
        }

        public void Dispose()
        {
            _redisServer.Dispose();
        }
    }
}