using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1000021;

            string x2 = x.ToString();

            bool isPalindrome = true;
            int n = 1;
            int tam = x2.Length;

            for (int i = 0; i < tam / 2; i++)
            {
                if (n < tam && x2[i] == x2[tam - n])
                    isPalindrome = true;
                else
                {
                    isPalindrome = false;
                    break;
                }

                n++;

            }


            Console.WriteLine(isPalindrome);
            Console.ReadKey();

        }
    }
}
