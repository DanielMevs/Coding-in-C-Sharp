using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Exercises
{
    public class HashSetUnionExercise
    {
        public static HashSet<T> CreateUnion<T>(
            HashSet<T> set1, HashSet<T> set2)
        {
            var hashSet = new HashSet<T>();
            foreach (var item in set1)
            {
                hashSet.Add(item);
            }
            foreach (var item in set2)
            {
                hashSet.Add(item);
            }
            return hashSet;
        }
    }
}
