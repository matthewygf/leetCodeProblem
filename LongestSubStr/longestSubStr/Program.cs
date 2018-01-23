using System;
using System.Collections.Generic;
using System.Text;

namespace longestSubStr
{
    class Program
    {
        static void Main(string[] args)
        {
            //var first = "bbbbbbb";
            //var second = "abcabcbb";
            var third = "tmmzuxt";
            //var fourth = "dvdf";
            //var result = GetLengthOfLongestSubstr(first);
            //var result2 = GetLengthOfLongestSubstr(second);
            var result3 = GetLengthOfLongestSubstr(third);
            //var result4 = GetLengthOfLongestSubstr(fourth);
        }

        private static int GetLengthOfLongestSubstr(string longStr){
            var characters = longStr.ToCharArray();
            var charactersDict = new Dictionary<char,int>();
            var totalLength = 0;
            int j = 0;
            for(int i = 0; i < longStr.Length; i++){
                if(charactersDict.ContainsKey(characters[i])){
                    // if it does contain it, we move the j value
                    Console.WriteLine($" contain {characters[i]}: i is {i} and j is {j}");
                    j = Math.Max(charactersDict[characters[i]], j);
                    Console.WriteLine($"comparing {charactersDict[characters[i]]} with {j}");
                }
                // if it does not contain it 
                    // add the character in the dictionary.
                    //Console.WriteLine($" i is {i} and j is {j}");
                    Console.WriteLine($"current total is {totalLength}");
                    totalLength = Math.Max(totalLength, i - j + 1);
                    Console.WriteLine($"updated total {totalLength} with character {characters[i]}");
                    var success = charactersDict.TryAdd(characters[i], i + 1);
                    if(!success){
                        charactersDict[characters[i]] = i + 1;
                    }
                    Console.WriteLine($"added character {characters[i]} and {i + 1}");
            }
            Console.WriteLine(totalLength);
            return 0;
        }
    }
}
