using System;
using System.Linq;

namespace P05.DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] inputFirstData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            DateTime firstDate = new DateTime(inputFirstData[0], inputFirstData[1], inputFirstData[2]);

            int[] inputSecondData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            DateTime secondDate = new DateTime(inputSecondData[0], inputSecondData[1], inputSecondData[2]);

            DateModifier date = new DateModifier(firstDate, secondDate);

            Console.WriteLine(date.GetDifference());
        }
    }
}
