using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicrosoftTestPreparation.ExamplesJun2018
{
    //Two strings A and B are isomorphic if there exists character mapping which replaces characters from A to get B.Rules for character mapping are:

    //all occurrences of one character (e.g. ‘x’) must be replaced with the same character(e.g. ‘y’)
    //no two different characters may map to the same character
    //a character may map to itself
    //Write a function that returns true if provided strings are isomorphic, otherwise false:

    //bool AreStringsIsomorphic(char* a, char* b)


    //The strings are NULL-terminated, with characters from lower case English alphabet ‘a’ – ‘z’.

    //Examples:
    //Input Output
    //A = “brain”, B = “space”	true
    //A = “noon”, B = “feet”	false
    //A = “aab”, B = “ccd”	true

    class Example01
    {
        public bool AreStringsIsomorphic(string a, string b)
        {
            var A = a.ToLower();
            var B = b.ToLower();
            int aInt = (int)'a';

            var distanceA = aInt - A[0];
            var distanceB = aInt - B[0];

            var diffFirst = distanceA + distanceB;
            var diff = diffFirst;
            
            for(int i = 0; i < B.Length; i++)
            {
                distanceA = aInt - A[i];
                distanceB = aInt - B[i];
                diff = distanceA + distanceB;

                Console.WriteLine("A: " + distanceA + " B: " + distanceB + " diff: " + diff);                
                if (diffFirst != diff)
                    return false;
            }
            return true;
        }

        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            bool result = true;
            var relation = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];
                char c;
                if (relation.TryGetValue(sChar, out c))
                {
                    Console.WriteLine("TryGetValue start c: " + c + " tChar: " + tChar);
                    if (c != tChar)
                    {
                        result = false;
                        break;
                    }
                }
                else if (relation.ContainsValue(tChar))
                {
                    Console.WriteLine("ContainsValue c: " + c + " tChar: " + tChar);
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Add in dict " + sChar + " and " + tChar);
                    relation.Add(sChar, tChar);
                }
            }
            return result;
        }

        public bool IsIsomorphic2(string s, string t)
        {
            int[] map = Enumerable.Repeat(-1, 175).ToArray();
            bool[] marked = Enumerable.Repeat(false, 175).ToArray();            

            for (int i = 0; i < s.Length; ++i)
            {
                if (map[s[i]] == -1) // Unvisited 
                {
                    if (marked[t[i]]) // Already has a mapping
                    {
                        return false;
                    }

                    marked[t[i]] = true;

                    map[s[i]] = t[i];
                }
                else if (map[s[i]] != t[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
