﻿using System;
using System.Collections.Generic;
using Contracts.Github;
using Github.Crawler.Dependencies;
using Ninject;
using NLog;

namespace Github.Crawler
{
    class Program
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private static readonly IKernel _kernel = new StandardKernel(new DependencyModule());

        static void Main()
        {
            _logger.Info("StackOverflow.Crawler is running...");

            var searchValue = "";
            var language = "csharp";
            List<GithubRepositoryInfo> result = new Worker().GetRepositories(searchValue, language);
            SaveRepositories(result);

            _logger.Info("Press ANY key to exit.");
            Console.ReadKey();
        }

        private static void SaveRepositories(List<GithubRepositoryInfo> repositories)
        {
            var repository = _kernel.Get<GithubRepository>();
            repositories.ForEach(repository.Save);
        }
    }
}
