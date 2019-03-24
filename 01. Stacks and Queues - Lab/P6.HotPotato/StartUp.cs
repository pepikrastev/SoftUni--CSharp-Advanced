using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        string[] childrens = Console.ReadLine().Split();
        int numberOfToss = int.Parse(Console.ReadLine());

        Queue<string> queueOfChildrens = new Queue<string>(childrens);

        while (queueOfChildrens.Count > 1)
        {
            for (int i = 1; i < numberOfToss; i++)
            {
                queueOfChildrens.Enqueue(queueOfChildrens.Dequeue());
            }

            Console.WriteLine($"Removed {queueOfChildrens.Dequeue()}");
        }

        Console.WriteLine($"Last is {queueOfChildrens.Dequeue()}");
    }
}