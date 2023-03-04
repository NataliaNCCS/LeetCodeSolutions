using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int[] arr2 =  TwoSum(arr, 6);
            Console.WriteLine($"[{arr2[0]}, {arr2[1]}]");
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {

            List<int> list = new List<int>();
            int[] nums2 = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                int esperado = target - n;
                list.Add(n);

                if (list.Contains(esperado) && list.IndexOf(esperado) != i)
                {
                    nums2[0] = list.IndexOf(esperado);
                    nums2[1] = i;

                }

            }

            return nums2;

        }
    }
}
