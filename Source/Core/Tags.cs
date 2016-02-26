﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Core
{
    public static class Tags
    {
        private const string TagFile = "Tags.json";

        public static Lazy<List<TagItem>> Root { get; } = new Lazy<List<TagItem>>(() =>
        {
            string fileContent = File.ReadAllText(TagFile);
            return JsonConvert.DeserializeObject<List<TagItem>>(fileContent);
        });
    }
}
