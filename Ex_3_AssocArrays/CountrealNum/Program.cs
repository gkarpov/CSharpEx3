using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CountrealNum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nums = new SortedDictionary<double, int>();

            List<double> input = Console.ReadLine().Split(' ').Select(Double.Parse).ToList();

            foreach(var num in input)
            {
                if (!nums.ContainsKey(num))
                    nums.Add(num, 0);

                nums[num]++;
            }

            foreach(var num in nums.Keys)
                Console.WriteLine("{0} -> {1}", num, nums[num]);
        }
    }
}
