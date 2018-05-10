using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAggreg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();

            var usrtraf = new SortedDictionary<string, long>();

            var usrips = new SortedDictionary<string, List<string>>();

            int num = int.Parse(Console.ReadLine());

            do
            {
                input = Console.ReadLine().Split(' ').ToList();



                if (usrtraf.ContainsKey(input[1]))
                {
                    usrtraf[input[1]] += long.Parse(input[2]);
                    if(!usrips[input[1]].Contains(input[0]))
                        usrips[input[1]].Add(input[0]);
                }
                else
                {
                    usrtraf[input[1]] = long.Parse(input[2]);
                    usrips[input[1]] = new List<string>();
                    usrips[input[1]].Add(input[0]);
                }   

                num--;

            } while (num>0);

            //printing results
            foreach (var usr in usrtraf)
            {
                Console.Write("{0}: {1} [", usr.Key, usr.Value);

                var tmplist = new List<string>();

                tmplist = usrips[usr.Key];

                tmplist.Sort();

                for (int i = 0; i < tmplist.Count - 1;i++)
                    Console.Write("{0}, ", tmplist[i]);
                Console.WriteLine("{0}]", tmplist[tmplist.Count-1]);
            }

        }
    }
}
