using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatcher
{
    class ArrayMatcher
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');
            string one = input[0];
            string two = input[1];

            List<char> result = new List<char>();
            if (input[2]== "join")
            {
                for (int i = 0; i < one.Length; i++)
                {
                    if (two.Contains(one[i]))
                    {
                        result.Add(one[i]);
                    }
                }
                result.Sort();
                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write(result[i]);
                } 
                    Console.WriteLine();
            }
            if (input[2] == "right exclude")
            {
                for (int i = 0; i < one.Length; i++)
                {
                    if (!two.Contains(one[i]))
                    {
                        result.Add(one[i]);
                    }
                }
                result.Sort();
                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write(result[i]);
                }
                    Console.WriteLine();
            }
            if (input[2] == "left exclude")
            {
                for (int i = 0; i < two.Length; i++)
                {
                    if (!one.Contains(two[i]))
                    {
                        result.Add(two[i]);
                    }
                }
                result.Sort();
                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine();
            }

        }
    }
}
