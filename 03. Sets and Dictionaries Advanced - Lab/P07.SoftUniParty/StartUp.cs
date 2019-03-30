using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.SoftUniParty
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuest = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }

                char isNumber = input[0];

                if (char.IsDigit(isNumber))
                {
                    vipGuest.Add(input);
                }
                else if (input.Length == 8)
                {
                    regularGuests .Add(input);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                char isNumber = input[0];

                if (char.IsDigit(isNumber))
                {
                    vipGuest.Remove(input);
                }
                else if (input.Length == 8)
                {
                    regularGuests .Remove(input);
                }
            }

            int sum = vipGuest.Count + regularGuests .Count;

            Console.WriteLine(sum);

            if (vipGuest.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipGuest));
            }
            Console.WriteLine(string.Join(Environment.NewLine, regularGuests ));
        }
    }
}
