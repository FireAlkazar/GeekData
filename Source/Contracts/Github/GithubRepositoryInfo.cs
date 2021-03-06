﻿namespace Contracts.Github
{
    public class GithubRepositoryInfo
    {
        public string Description { get; set; }
        public string FullName { get; set; }
        public string HtmlUrl { get; set; }
        public string Language { get; set; }
        public string Name { get; set; }
        public string Readme { get; set; } = string.Empty;
        public string Tag { get; set; }
        public string StargazersCount { get; set; }

        public override string ToString()
        {
            return $"{HtmlUrl} - {StargazersCount} stars";
        }
    }
}
