using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] strs = {"flower", "flow", "flight"};

            Array.Sort(strs);
            string first = strs[0];
            string last = strs[strs.Length - 1];
            string res = "";

            for (int i = 0; i < strs[0].Length; i++)
            {
                if (first[i] == last[i])
                {
                    res += first[i];
                }
                else
                    break;

            }

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
