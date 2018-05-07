using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OddAppears
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var strs = new Dictionary<string, int>();

            List<string> input = Console.ReadLine().Split(' ').ToList();

            foreach (var str in input)
            {
                string tmp = str.ToLower();
                if (!strs.ContainsKey(tmp))
                    strs.Add(tmp, 0);
                
                strs[tmp]++;
            }

            input.Clear();

            foreach (var str in strs.Keys)
            {
                if (strs[str] % 2 == 1)
                    input.Add(str);
                
            }

            for (int i = 0; i < input.Count-1;i++)
                Console.Write("{0}, ", input[i].ToLower());
            
            Console.WriteLine(input[input.Count-1].ToLower());
        }
    }
}
