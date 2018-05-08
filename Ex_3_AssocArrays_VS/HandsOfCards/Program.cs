using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>();
            string name = "";
            var cards = new List<string>();
            var perspoints = new Dictionary<string, int>();

            do
            {
                input = Console.ReadLine().Split(':').ToList();
                
                if (input[0] == "JOKER")
                    break;

                name = input[0];

                if (!perspoints.ContainsKey(name))
                    perspoints[name] = 0;
                
                cards = input[1].Split(',').ToList();

                //eleminate dublicates
                for (int i = 0; i < cards.Count - 1; i++)
                {

                    for (int k = cards.Count-1; k > i; k--)
                        if (cards[k] == cards[i])
                            cards.RemoveAt(k);
                }
                
                foreach (var card in cards)
                {
                    int sum = 0;
                    if ((char)card[1] > '9')
                    {
                        switch ((char)card[1])
                        {
                            case 'J':
                                sum += 11;
                                break;
                            case 'Q':
                                sum += 12;
                                break;
                            case 'K':
                                sum += 13;
                                break;
                            case 'A':
                                sum += 14;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        sum += card[1];
                    }

                    switch ((char)card[2])
                    {
                        case 'S':
                            sum*=4;
                            break;
                        case 'H':
                            sum *= 3;
                            break;
                        case 'D':
                            sum *= 2;
                            break;
                        case 'C':
                            sum *= 1;
                            break;
                        default:
                            break;
                    }

                    perspoints[name] += sum;

                }

            } while (true);
            
            foreach(var pers in perspoints)
                Console.WriteLine("{0}: {1}", pers.Key, pers.Value);

        }
    }
}
