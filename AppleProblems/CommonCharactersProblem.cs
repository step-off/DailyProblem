using System;
using System.Collections.Generic;
using System.Text;

namespace AppleProblems
{
/*
    Given a list of strings, find the list of characters that appear in all strings.
    Here's an example and some starter code:

    def common_characters(strs):
      # Fill this in.

    print(common_characters(['google', 'facebook', 'youtube']))
    # ['e', 'o']
         
*/
    public class CommonCharactersProblem
    {
        public List<char> Solve(List<string> input)
        {
            var result = new List<char>();
            var dict = new Dictionary<char, List<string>>();
            var inputCount = input.Count;

            foreach (var item in input)
                foreach (var currentChar in item)
                {
                    if (dict.ContainsKey(currentChar))
                    {
                        var currentList = dict[currentChar];
                        if (currentList.Contains(item))
                            continue;
                        else
                            currentList.Add(item);
                    } else
                        dict.Add(currentChar, new List<string>() {item});
                }
            foreach (var character in dict.Keys)
            {
                var listOfStrings = dict[character];
                if (listOfStrings.Count == inputCount)
                    result.Add(character);
            }
            return result;
        }
    }
}
