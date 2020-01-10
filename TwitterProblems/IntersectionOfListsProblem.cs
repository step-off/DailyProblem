using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterProblems
{
/*
    Given sorted lists, find the intersection of those lists.

    Here's an example and some starter code.

    def intersection(list1, list2, list3):
      # Fill this in.

    print(intersection([1, 2, 3, 4], [2, 4, 6, 8], [3, 4, 5]))
    # [4]
*/
    public class IntersectionOfListsProblem
    {
        public T[] Solve<T>(params T[][] lists)
        {
            var result = new HashSet<T>();
            var dict = new Dictionary<T, HashSet<int>>();
            var listsLength = lists.Length;

            for (int i = 0; i < lists.Length; i++)
            {
                var list = lists[i];
                for (int j = 0; j < list.Length; j++)
                {
                    var listItem = list[j];
                    if (dict.ContainsKey(listItem))
                        dict[listItem].Add(i);
                    else
                        dict[listItem] = new HashSet<int>() { i };
                    if (dict[listItem].Count == listsLength)
                        result.Add(listItem);
                }
            }  
            return result.ToArray();
        }
    }
}
