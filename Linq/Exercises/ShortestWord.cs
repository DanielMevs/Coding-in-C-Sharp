using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Exercises
{
    public class ShortestWord
    {
        public static string FindShortestWord(List<string> words)
        {
            if (words.Count == 0)
            {
                throw new Exception("This list is empty");
            }
            return words.OrderBy(word => word.Length).First();

        }
    }
}
