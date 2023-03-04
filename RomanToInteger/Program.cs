using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "LVIII";


            int res = 0;
            Dictionary<char, int> romans = new Dictionary<char, int>
            {
                { 'I', 1},
                { 'V', 5},
                { 'X', 10},
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };


            for(int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romans[s[i]] < romans[s[i + 1]])
                {
                    res -= romans[s[i]];
                }
                else
                {
                    res += romans[s[i]];
                }

            }

            Console.WriteLine(res);

            Console.ReadKey();  

        }
    }
}
