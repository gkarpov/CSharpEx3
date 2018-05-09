using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>();

            var cntr = new Dictionary<string, SortedDictionary<int, string>>();

            //countries sum populations
            var cntsm = new SortedDictionary<int, string>();

            do
            {
                input = Console.ReadLine().Split('|').ToList();

                if (input[0] == "report")
                    break;

                var tmp = new SortedDictionary<int, string>();

                tmp[int.Parse(input[2])] = input[0];
                cntr[input[1]] = tmp;
                

            } while (true);

            foreach(var cn in cntr)
            {
                int sm = 0;
                foreach (var tsm in cn.Value)
                    sm += tsm.Key;

                cntsm[sm] = cn.Key;
            }

            //printing results
            //foreach(var cn in cntsm)
            for (int i = 0; i < cntsm.Count;i++)
            {
                Console.WriteLine("{0} (total population: {1})}", cntsm.Values.ElementAt(i), cntsm.Keys.ElementAt(i));
                foreach(var tn in cntr[cn.Value])
                    Console.WriteLine("=>{0}: {1}", tn.Value, tn.Key);
            }
                
        }
    }
}
