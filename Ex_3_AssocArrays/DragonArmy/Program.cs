using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonArmy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, SortedDictionary<string, Dictionary<string, long>>>();

            int num = int.Parse(Console.ReadLine());

            do
            {
                var stat = new Dictionary<string, long>();
                var drag = new SortedDictionary<string, Dictionary<string, long>>();

                var inp = Console.ReadLine().Split(' ').ToList<string>();

                if (inp[2] == "null")
                    stat["damage"] = 45;
                else
                    stat["damage"] = long.Parse(inp[2]);
                
                if (inp[3] == "null")
                    stat["health"] = 250;
                else
                    stat["health"] = long.Parse(inp[3]);
                
                if (inp[3] == "null")
                    stat["armor"] = 10;
                else
                    stat["armor"] = long.Parse(inp[4]);


                //if(dict.ContainsKey())
                drag[inp[1]] = stat;

                if(dict.ContainsKey(inp[0]))
                {
                    if (dict[inp[0]].ContainsKey(inp[1]))
                            dict[inp[0]][inp[1]] = stat;
                    else
                            dict[inp[0]][inp[1]] = stat;
                }
                else
                {
                    dict[inp[0]] = new SortedDictionary<string, Dictionary<string, long>>();
                    dict[inp[0]] = drag;
                }

                    
                num--;
            } while (num > 0);
            foreach (var dr in dict)
            {
                Console.WriteLine("{0}: ", dr.Key);

                //var tmplist = new List<string>();

                //tmplist = usrips[usr.Key];

                //tmplist.Sort();

                //for (int i = 0; i < tmplist.Count - 1; i++)
                //    Console.Write("{0}, ", tmplist[i]);
                //Console.WriteLine("{0}]", tmplist
            }
        }
    }
}
