using System;
using System.Collections.Generic;

namespace Shop
{
    class Program
    {
        static Shop shop = new Shop(60, 25, 15, 12, 15, 20, 35);
        static void Main(string[] args)
        {
            Queue<Buyer> buyers = new Queue<Buyer>();
            int countDays = 1; ;
            while(countDays < 21)
            {
                Console.WriteLine("-----DAY " + countDays + "-----");
                Console.WriteLine("-----BUYER 1-----");
                buyers.Enqueue(new Buyer(ListOfProduct(), 200));
                shop.NextBuyer(buyers.Dequeue());
                Console.WriteLine(" ");
                Console.WriteLine("-----BUYER 2-----");
                buyers.Enqueue(new Buyer(ListOfProduct(), 100));
                shop.NextBuyer(buyers.Dequeue());
                countDays++;
                shop.ExpDateCount();
                Console.WriteLine("============================================");
                if (countDays % 7 == 0)
                {
                    Console.WriteLine("-----DAY " + countDays + "-----");
                    shop.StatisticForLooses();
                }
            }
            
            //buyers.Enqueue(new Buyer(ListOfProduct(), 100));
            //buyers.Enqueue(new Buyer(ListOfProduct(), 95));
            //buyers.Enqueue(new Buyer(ListOfProduct(), 100));
            //buyers.Enqueue(new Buyer(ListOfProduct(), 80));
            //buyers.Enqueue(new Buyer(ListOfProduct(), 90));
            //buyers.Enqueue(new Buyer(ListOfProduct(), 200));

            //while (buyers.Count != 0)
            //{
            //    shop.NextBuyer(buyers.Dequeue());
            //}
        }
        static List<Products> ListOfProduct()
        {
            List <Products> list = new List<Products>();
            Random random = new Random();
            int countOfMilk = random.Next(0, 4);
            for (int i = 0; i < countOfMilk; i++)
            {
                list.Add(new Milk());
            }
            int countOfBread = random.Next(0, 4);
            for (int i = 0; i < countOfBread; i++)
            {
                list.Add(new Bread());
            }
            int countOfCake = random.Next(0, 4);
            for (int i = 0; i < countOfCake; i++)
            {
                list.Add(new Cake());
            }
            int countOfSuger = random.Next(0, 4);
            for (int i = 0; i < countOfSuger; i++)
            {
                list.Add(new Suger());
            }
            int countOfApple = random.Next(0, 4);
            for (int i = 0; i < countOfApple; i++)
            {
                list.Add(new Apple());
            }
            int countOfWater = random.Next(0, 4);
            for (int i = 0; i < countOfWater; i++)
            {
                list.Add(new Water());
            }
            int countOfBanana = random.Next(0, 4);
            for (int i = 0; i < countOfBanana; i++)
            {
                list.Add(new Banana());
            }
            return list;
           
        }
    }
}
