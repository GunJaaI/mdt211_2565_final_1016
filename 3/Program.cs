using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> calculate = new Queue<string>();
        while (true) {
            Console.Write("-> ");
            string queue = Console.ReadLine();
            if (queue == "Exit") {
                break;
            } else {
                calculate.Push(queue);
            }
        }
        Console.WriteLine(calculate.Get(calculate.GetLength() - 3));
        Console.WriteLine(calculate.Get(calculate.GetLength() - 2));
        Console.WriteLine(calculate.Get(calculate.GetLength() - 1));

    }
}