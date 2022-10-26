using System;
using System.Collections.Generic;
using System.Linq;

namespace ITEC104_ACTIVITY5_VENANCIO
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = test(new List<int>(new int[] { 10, 20, 35, 65, 48, 53, 5, 1 }));

            Console.WriteLine("10, 20, 35, 65, 48, 53, 5, 1");

            foreach (var list in mylist)
            {
                Console.Write(list + " ");
            }
            Console.ReadLine();
        }
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 != 5).ToList();
        }

        
    }
    
}
