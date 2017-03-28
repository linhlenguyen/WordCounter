using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    public class WordCount
    {
        public IDictionary<String, int> WordCountMap { get; set; }
        
        public WordCount(string text)
        {
            string[] ds = new string[1];
            ds[0] = text;
            WordCountMap = processInput(ds);
        }

        public WordCount(string[] text)
        {
            WordCountMap = processInput(text);
        }

        private static IDictionary<String, int> processInput(string[] dataSource)
        {
            IDictionary<String, int> results = new Dictionary<String, int>();
            string word = "";
            for (int k = 0; k < dataSource.Length; k++)
            {
                word = "";
                for (int i = 0; i < dataSource[k].Length; i++)
                {
                    if (StringUtils.isValidChar(dataSource[k][i]))
                    {
                        word += dataSource[k][i];
                    }
                    else if (word.Length > 0)
                    {
                        results.AddWithFnc(word, (x => x + 1));
                        word = "";
                    }
                }
                //Handle words at the end of line
                if (word.Length > 0)
                {
                    results.AddWithFnc(word, (x => x + 1));
                }
            }
            return results;
        }
        
        public string ShowResult()
        {
            var r = WordCountMap.ToList();
            r.Sort((i, j) => j.Value.CompareTo(i.Value));
            return r.Show();
        }
    }
}
