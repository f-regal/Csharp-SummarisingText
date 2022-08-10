using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            var words = text.Split(' ');

            List<string> newWords = new List<string>();
            var letterCounter = 0;

            for (var i = 0; i <= words.Length; i++)
            {

                newWords.Add(words[i]);

                letterCounter += words[i].Length + 1;

                if (letterCounter > maxLength)
                {
                    break;
                }

            }

            var summary = String.Join(" ", newWords);
            Console.WriteLine(summary);
            return summary;
        }
    }
}
