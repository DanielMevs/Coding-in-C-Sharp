using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Exercises
{
    public class AnyAndAll
    {
        public static bool IsAnyWordWhiteSpace(List<string> words)
        {
            var isAnyWhiteSpace = words.Any(
                word => word.All(
                    letter => 
                        char.IsWhiteSpace(letter))
            );
            return isAnyWhiteSpace;
        }
    }
}
