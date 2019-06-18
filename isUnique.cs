//Implement an algorithm to determine if a string has all unique characters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isUnique("bol"));
        }

        public static bool isUnique(string input)
        {
            //if (input.Length > 128)
            //    return false;

            bool[] char_set = new bool[128];
            for (int i = 0; i < input.Length; i++)
            {
                int val = input[i];
                if (char_set[val])
                    return false;
                char_set[val] = true;
            }
            return true;

            //var set = new HashSet<char>();
            //for (int i = 0; i < input.Length; i++)
            //    if (!set.Add(input[i]))
            //        return false;
            //return true;
        }
    }
}
