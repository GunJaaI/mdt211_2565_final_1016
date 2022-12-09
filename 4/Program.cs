using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> calculate = new Queue<string>();
        while (true) {
            for (int i = 0;i < 3;i++) {
                Console.Write("-> ");
                string queue = Console.ReadLine();
                calculate.Push(queue);
                if (queue == "true") {
                   for (int j = 0;j < 3;j++) {
                        Console.Write(" -> ");
                        queue = Console.ReadLine();
                        calculate.Push(queue);
                        if (queue == "true") {
                            for (int k = 0;k < 3;k++) {
                                Console.Write("  -> ");
                                queue = Console.ReadLine();
                                calculate.Push(queue);
                                if (queue == "flase") {
                                    for (int l = 0;l < 3;l++) {
                                        Console.Write("  -> ");
                                        queue = Console.ReadLine();
                                        calculate.Push(queue);
                                    }
                                    if (queue == "flase") {
                                        for (int m = 0;m < 3;m++) {
                                            Console.Write(" -> ");
                                            queue = Console.ReadLine();
                                            calculate.Push(queue);
                                        }
                                        if (queue == "flase") {
                                            for (int n = 0;n < 3;n++) {
                                                Console.Write(" -> ");
                                                queue = Console.ReadLine();
                                                calculate.Push(queue);
                                            }
                                            if (queue == "true") {
                                                for (int o = 0;o < 3;o++) {
                                                    Console.Write("  -> ");
                                                    queue = Console.ReadLine();
                                                    calculate.Push(queue);
                                                }
                                                if (queue == "flase") {
                                                    for (int p = 0;p < 3;p++) {
                                                        Console.Write("  -> ");
                                                        queue = Console.ReadLine();
                                                        calculate.Push(queue);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                } 
            }
            break;
        }
        Console.Clear();
        Console.WriteLine("{0} ({1})",calculate.Get(0),calculate.Get(1));
        Console.WriteLine(" {0} ({1})",calculate.Get(3),calculate.Get(4));
        Console.WriteLine("  {0} ({1})",calculate.Get(6),calculate.Get(7));
        Console.WriteLine("  {0} ({1})",calculate.Get(9),calculate.Get(10));
        Console.WriteLine(" {0} ({1})",calculate.Get(12),calculate.Get(13));
        Console.WriteLine(" {0} ({1})",calculate.Get(15),calculate.Get(16));
        Console.WriteLine("  {0} ({1})",calculate.Get(18),calculate.Get(19));
        Console.WriteLine("  {0} ({1})",calculate.Get(21),calculate.Get(22));
    }   
}