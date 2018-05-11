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
            var dict = new Dictionary<string, SortedDictionary<string, Dictionary<string, double>>>();

            int num = int.Parse(Console.ReadLine());

            do
            {
                var stat = new Dictionary<string, double>();
                var drag = new SortedDictionary<string, Dictionary<string, double>>();

                var inp = Console.ReadLine().Split(' ').ToList<string>();

                if (inp[2] == "null")
                    stat["damage"] = 45;
                else
                    stat["damage"] = double.Parse(inp[2]);
                
                if (inp[3] == "null")
                    stat["health"] = 250;
                else
                    stat["health"] = double.Parse(inp[3]);
                
                if (inp[4] == "null")
                    stat["armor"] = 10;
                else
                    stat["armor"] = double.Parse(inp[4]);


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
                    dict[inp[0]] = new SortedDictionary<string, Dictionary<string, double>>();
                    dict[inp[0]] = drag;
                }

                    
                num--;
            } while (num > 0);



            foreach (var dr in dict)
            {
                Console.Write("{0}::(", dr.Key);

                double dm = 0;
                double hl = 0;
                double am = 0;

                foreach(var nm in dr.Value)
                {
                    dm += nm.Value["damage"];    
                    hl += nm.Value["health"];
                    am += nm.Value["armor"];
                }

                //Console.WriteLine("{0}/{1}/{2})", Math.Round(dm/dr.Value.Count, 2), Math.Round(hl/dr.Value.Count, 2), Math.Round(am/ dr.Value.Count, 2));
                Console.WriteLine("{0:0.00}/{1:0.00}/{2:0.00})", dm/dr.Value.Count, hl/dr.Value.Count , am/dr.Value.Count);

                foreach (var nm in dr.Value)
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",
                                      nm.Key,
                                      nm.Value["damage"],
                                      nm.Value["health"],
                                      nm.Value["armor"]);
                }
            }
        }
    }
}
