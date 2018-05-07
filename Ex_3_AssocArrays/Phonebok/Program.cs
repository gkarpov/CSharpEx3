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
            var book = new Dictionary<string, string>();
            List<string> input = new List<string>();

            do
            {
                input = Console.ReadLine().Split(' ').ToList();

                if (input[0] == "A")
                {
                    book[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if(book.ContainsKey(input[1]))
                        Console.WriteLine("{0} -> {1}", input[1], book[input[1]]);
                    else
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                }
            }
            while (input[0] != "END");
                
          }
    }
}
