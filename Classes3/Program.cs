using System;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Purchase[] purchases =
            {
                new Purchase("milk", 400, 2, DayOfTheWeek.Monday),
                new Purchase("bread", 300, 1, DayOfTheWeek.Tuesday),
                new Purchase("icecream", 600, 3, DayOfTheWeek.Wednesday),
                new Purchase("oil", 800, 4, DayOfTheWeek.Sunday),
                new Purchase("bubblegum", 50, 5, DayOfTheWeek.Friday)
            };

            //2
            foreach (var item in purchases)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //3
            double totalCost = 0;
            Purchase maxPurchase = purchases[0];

            foreach (var item in purchases)
            {
                totalCost += item.GetCost(); 

                if(item.GetCost() > maxPurchase.GetCost())
                {
                    maxPurchase = item;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Average cost = " + totalCost / purchases.Length);
            Console.WriteLine("The day of the most expensive purchase - " + maxPurchase.Day);
            Console.WriteLine();

            //4
            Array.Sort(purchases);

            //5
            foreach (var item in purchases)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
