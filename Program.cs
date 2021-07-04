using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = findMedian(arr);

            Console.WriteLine(result);
        }

        private static int findMedian(List<int> arr)
        {
            
            var itemsArray = arr.ToArray();
            Array.Sort(itemsArray);

            return itemsArray[(itemsArray.Length - 1) / 2+1];
        }
    }
}
