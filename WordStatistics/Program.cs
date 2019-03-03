using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordStatistics
{
    class Program
    {
        static void Main(string[] args)
        {            
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            char[] separators = { ' ',',','.' };
            string str = "Вот дом, Который построил Джек. А это пшеница, Которая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            string[] tmp = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
           
            string[] unique = tmp.Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();
            int count = 0;
            for (int i = 0; i < unique.Length; i++)
            {
                for (int j = 0; j <tmp.Length; j++)
                {
                    if (unique[i] == tmp[j])
                        count++;
                }
                wordCount.Add(unique[i], count);
                count = 0;
            }
            int k = 1;
            foreach (KeyValuePair<string, int> pair in wordCount)
            {                
                Console.WriteLine("{0}.\t{1} - {2}", k, pair.Key, pair.Value);
                k++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Всего слов {0}\nУникальных {1}", tmp.Length,unique.Length);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
