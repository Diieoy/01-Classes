using System;

namespace Classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Worker[] workers =
            {
                new Worker("Anton Slutsky", 50, 5),
                new Worker("Vasily Petrov", 30, 2),
                null,
                new Worker("Alla Ivanova", 20, 1),
                new Worker()
            };

            //2           
            foreach (var item in workers)
            {
                if (item != null)
                {
                    item.Show();
                    Console.WriteLine();
                }
            }

            //3
            workers[workers.Length - 1].Transport = 70;

            //4
            Console.WriteLine("Duration = " + (workers[0].Days + workers[1].Days));
            Console.WriteLine();

            //5
            foreach (var item in workers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
