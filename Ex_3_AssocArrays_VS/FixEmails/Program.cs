using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            int i = 0;
            string nm = "";
            string eml = "";

            do
            {

                i++;

                if (i % 2 == 1)
                {
                    nm = Console.ReadLine();
                    if (nm == "stop")
                    {
                        break;
                    }
                    else
                    {
                        if (!dict.ContainsKey(nm))
                            dict[nm] = "";
                    }
                }
                else
                {
                    eml = Console.ReadLine();
                    if (!(eml[eml.Length - 2] == 'u' && (eml[eml.Length - 1] == 'k' || eml[eml.Length - 1] == 's')))
                        dict[nm] = eml;
                    else
                        dict.Remove(nm);
                }
            } while (true);

            foreach (var obj in dict)
                Console.WriteLine("{0} -> {1}", obj.Key, obj.Value);

        }
    }
}
