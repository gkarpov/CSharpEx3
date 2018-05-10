using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>();
            string name = "";
            string ip = "";
            //var ipmsgs = new Dictionary<string, int>();
            var persips = new SortedDictionary<string, Dictionary<string, int>>();

            do
            {
                input = Console.ReadLine().Split(' ').ToList();
                
                if (input[0] == "end")
                    break;

                name = input[2].Substring(5);
                ip = input[0].Substring(3);

                Dictionary<string, int> tmp = new Dictionary<string, int>();

                if (!persips.ContainsKey(name))
                {
                    tmp[ip] = 1;
                    persips[name] = tmp;
                }
                else
                {
                    if (!persips[name].ContainsKey(ip))
                        persips[name][ip] = 1;
                    else
                        persips[name][ip]++;
                } 
            
            } while (true);


            foreach (var nam in persips)
            {
                Console.WriteLine("{0}: ", nam.Key);
                
                Dictionary<string, int> tmp = new Dictionary<string, int>();
                tmp = nam.Value;

                for (int k = 0; k < nam.Value.Count - 1; k++)
                {

                    Console.Write("{0} => {1}, ", tmp.Keys.ElementAt(k), tmp.Values.ElementAt(k));
                }
                Console.WriteLine("{0} => {1}.", tmp.Keys.ElementAt(nam.Value.Count - 1), tmp.Values.ElementAt(nam.Value.Count - 1));
            }
            
        }
    }
}
