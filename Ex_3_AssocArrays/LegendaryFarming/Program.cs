using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryFarming
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, long>();
            var junk = new SortedDictionary<string, long>();
            bool stop = false;


            dict["shards"] = 0;
            dict["fragments"] = 0;
            dict["motes"] = 0;


            do
            {

                var input = Console.ReadLine().Split(' ').ToList<string>();

                for (int i = 0;i<input.Count() ; i += 2)
                {

                    input[i + 1] = input[i + 1].ToLower();

                    if (input[i + 1] == "shards" || input[i + 1] == "fragments" || input[i + 1] == "motes")
                    {

                        dict[input[i + 1]] += long.Parse(input[i]);
                    
                        if (dict[input[i + 1]] >= 250)
                        {
                            string obj = "";
                            switch (input[i + 1])
                            {
                                case "shards":
                                    obj = "Shadowmourne";
                                    break;
                                case "fragments":
                                    obj = "Valanyr";
                                    break;
                                case "motes":
                                    obj = "Dragonwrath";
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("{0} obtained!", obj);

                            dict[input[i + 1]]-=250;

                            //sortdict
                            var sortedDict = from entry in dict orderby entry.Value descending select entry;
                            //printdict
                            foreach(var it in sortedDict)
                                Console.WriteLine("{0}: {1}", it.Key, it.Value);
                           

                            //printjunk
                            foreach (var it in junk)
                                Console.WriteLine("{0}: {1}", it.Key, it.Value);
                            
                            stop = true;
                            break;
                        }    
                    }else{
                        if (!junk.ContainsKey(input[i + 1]))
                        {
                            junk[input[i + 1]] = long.Parse(input[i]);
                        }
                        else
                        {
                            junk[input[i + 1]] += long.Parse(input[i]);
                        }
                    }

                }

            } while (!stop);
        }
    }
}
