using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Exercises
{
    public class ContainsAndCount
    {
        public static int CountListsContainingZeroLongerThan(
            int length,
            List<List<int>> listsOfNumbers)
        {
            var result = listsOfNumbers.Count(listOfNums =>
                listOfNums.Contains(0) &&
                listOfNums.Count > length);
            return result;
        }
    }
}
