using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace tNine
{
    public class DictionaryLoader
    {
        private Dictionary<string, List<string>> _dictionary;

        public DictionaryLoader()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyDictionary.json");
            var json = File.ReadAllText(filePath);
            _dictionary = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
        }

        public List<string> GetSuggestions(string prefix)
        {
            if (_dictionary.ContainsKey(prefix))
            {
                return _dictionary[prefix];
            }

            return new List<string>();
        }
    }
}
