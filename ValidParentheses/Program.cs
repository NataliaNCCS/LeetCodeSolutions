using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "()[]{}";

            bool valid = false;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(' && s[i+1] == ')'
                    || s[i] == '[' && s[i+1] == ']'
                    || s[i] == '{' && s[i+1] == '}'
                    || s[i] == ')' && s[i-1] == '('
                    || s[i] == ']' && s[i-1] == '['
                    || s[i] == '}' && s[i-1] == '{')
                {
                    valid = true;
                }
                else 
                    valid = false;
            }

            Console.WriteLine(valid);
            Console.ReadKey();

        }
    }
}
