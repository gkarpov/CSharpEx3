using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, long>();

            int i =0;
            string tmp = "";
            long count;

            do
            {

                i++;

                if (i % 2 == 1)
                {
                    tmp = Console.ReadLine();
                    if (tmp == "stop")
                    {
                        break;
                    }
                    else
                    {
                        if(!dict.ContainsKey(tmp))
                            dict[tmp] = 0;
                    }
                }
                else
                {
                    count = long.Parse(Console.ReadLine());
                    dict[tmp] += count;
                }
            } while (true);

            foreach(var obj in dict)
                Console.WriteLine("{0} -> {1}", obj.Key, obj.Value);

        }
    }
}
