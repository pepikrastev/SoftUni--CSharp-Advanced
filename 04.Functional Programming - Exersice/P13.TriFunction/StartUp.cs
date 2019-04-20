using System;
using System.Linq;

namespace P13.TriFunction
{
    class StartUp
    {
        static void Main(string[] args)
        {
          int number = int.Parse(Console.ReadLine());

            Func<string, char[]> funcToChArr = x => x.ToCharArray();
            Func<char, int> chToInt = x => (int)x;
            Func<string, bool> finalFunc = x => funcToChArr(x)
                                                    .Select(chToInt)
                                                    .Sum() >= number;

            Console.WriteLine(Console.ReadLine()
                .Split()
                .FirstOrDefault(finalFunc));

            //or..
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine(Console.ReadLine()
            //    .Split()
            //    .FirstOrDefault(x => x.ToCharArray()
            //    .Select(y => (int)y)
            //    .Sum() >= number));
        }
    }
}
