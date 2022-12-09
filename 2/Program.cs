using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<char> calculate = new Queue<char>();
        int x = 0;
        int y = 0;
        while(true)
        {
            Console.Write("-> ");
            char queue = char.Parse(Console.ReadLine());
            if (queue == '(') {
                calculate.Push(queue);
                x++;
            } else if (queue == ')') {
                calculate.Push(queue);
                y++;
            } else { break; }
        }
        if (x == y) {
            Console.WriteLine("Valid");
                
        } else {
            Console.WriteLine("Invalid");
        }

    }
}