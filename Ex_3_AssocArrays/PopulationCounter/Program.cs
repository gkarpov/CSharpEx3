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
            List<string> input = new List<string>();

            var cntr = new Dictionary<string, SortedDictionary<string, long>>();

            //countries sum populations
            var cntsm = new SortedDictionary<string, long>();

            do
            {
                input = Console.ReadLine().Split('|').ToList();

                if (input[0] == "report")
                    break;

                var tmp = new SortedDictionary<string, long>();

                if (cntr.ContainsKey(input[1]))
                    tmp = cntr[input[1]];
                tmp.Add(input[0], long.Parse(input[2]));
                cntr[input[1]] = tmp;


            } while (true);

            foreach (var cn in cntr)
            {
                long sm = 0;
                foreach (var tsm in cn.Value)
                    sm += tsm.Value;

                cntsm[cn.Key] = sm;
            }

            var sortedDict = from entry in cntsm orderby entry.Value descending select entry;
            //var myList = cntsm.ToList();


            //prlonging results
            foreach (var cn in sortedDict)
            {
                string twn = cn.Key;
                long pop = cn.Value;
                Console.WriteLine("{0} (total population: {1})", twn, pop);
                var sortedDict2 = from entry in cntr[twn] orderby entry.Value descending select entry;
                foreach (var tn in sortedDict2)
                    Console.WriteLine("=>{0}: {1}", tn.Key, tn.Value);
            }

        }
    }
}
