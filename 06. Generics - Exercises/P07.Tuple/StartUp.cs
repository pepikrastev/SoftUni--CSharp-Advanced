using System;

namespace P07.Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine()
                .Split();

            string name = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];

            Tuple<string, string> firstTuple = new Tuple<string, string>(name, address);

            string[] secondInput = Console.ReadLine()
                .Split();

            string secondName = secondInput[0];
            int liters = int.Parse(secondInput[1]);

            Tuple<string, int> secondTuple = new Tuple<string, int>(secondName, liters);

            string[] thirdInput = Console.ReadLine()
                .Split();

            int intNum = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(intNum, doubleNum);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
