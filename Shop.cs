using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Shop
    {
        Apple apple1 = new Apple();
        Bread bread1 = new Bread();
        Banana banana1 = new Banana();
        Milk milk1 = new Milk();
        Suger suger1 = new Suger();
        Cake cake1 = new Cake();
        Water water1 = new Water();

        public Queue<Milk> milk = new Queue<Milk>();
        public Queue<Bread> bread = new Queue<Bread>();
        public Queue<Cake> cake = new Queue<Cake>();
        public Queue<Suger> suger = new Queue<Suger>();
        public Queue<Water> water = new Queue<Water>();
        public Queue<Banana> banana = new Queue<Banana>();
        public Queue<Apple> apple = new Queue<Apple>();
        public Shop(int milkCount, int breadCount, int cakeCount, int sugerCount, int waterCount, int bananaCount, int appleCount)
        {
            for (int i = 0; i < milkCount; i++)
            {
                milk.Enqueue(new Milk());
            }
            for (int i = 0; i < cakeCount; i++)
            {
                cake.Enqueue(new Cake());
            }
            for (int i = 0; i < breadCount; i++)
            {
                bread.Enqueue(new Bread());
            }
            for (int i = 0; i < sugerCount; i++)
            {
                suger.Enqueue(new Suger());
            }
            for (int i = 0; i < waterCount; i++)
            {
                water.Enqueue(new Water());
            }
            for (int i = 0; i < bananaCount; i++)
            {
                banana.Enqueue(new Banana());
            }
            for (int i = 0; i < appleCount; i++)
            {
                apple.Enqueue(new Apple());
            }
        }
        public void NextBuyer(Buyer buyer)
        {
            int totalPrice = 0;
            int milkCount = 0;
            int breadCount = 0;
            int cakeCount = 0;
            int sugerCount = 0;
            int bananaCount = 0;
            int waterCount = 0;
            int appleCount = 0;

            foreach (Products p in buyer._productList)
            {
                
                if (p is Milk)
                {
                    milkCount++;
                    if (milk.Count != 0 && milk1.expDate > 0)
                    {
                        milk.Dequeue();
                        totalPrice += ((Milk)p).price;
                    }
                    else
                    {
                        Console.WriteLine("Milk is over");
                        continue;
                    }
                }
                if (p is Cake)
                {
                    cakeCount ++;
                    if (cake.Count != 0 && cake1.expDate > 0)
                    {
                        cake.Dequeue();
                        totalPrice += ((Cake)p).price;
                    }
                    else
                    {
                        Console.WriteLine("Cakes are over");
                        continue;
                    }
                }

                if (p is Bread)
                {
                    breadCount++;
                    if (bread.Count != 0 && bread1.expDate > 0)
                    {
                        bread.Dequeue();
                        totalPrice += ((Bread)p).price;
                    }
                    else
                    {
                        Console.WriteLine("Bread is over");
                        continue;
                    }
                }

                if (p is Suger)
                {
                    sugerCount++;
                    if (suger.Count != 0 && suger1.expDate > 0)
                    {
                        suger.Dequeue();
                        totalPrice += ((Suger)p).price;
                    }
                    else
                    {
                        Console.WriteLine("Suger is over");
                        continue;
                    }
                }
                if (p is Water)
                {
                    waterCount++;
                    if (water.Count != 0 && water1.expDate > 0)
                    {
                        water.Dequeue();
                        totalPrice += ((Water)p).price;
                    }
                    else
                    {
                        Console.WriteLine("Water is over");
                        continue;
                    }
                }
                if (p is Banana)
                {
                    bananaCount++;
                    if (banana.Count != 0 && banana1.expDate > 0)
                    {
                        banana.Dequeue();
                        totalPrice += ((Banana)p).price;
                    }
                    else
                    {
                        Console.WriteLine("Banana is over");
                        continue;
                    }
                }
                if (p is Apple)
                {
                    appleCount++;
                    if (apple.Count != 0 && apple1.expDate > 0)
                    {
                        apple.Dequeue();
                        totalPrice += ((Apple)p).price;
                    }
                    else
                    {
                        Console.WriteLine("Apples are over");
                        continue;
                    }
                }
            }
            Console.WriteLine("Milk - " + milkCount);
            Console.WriteLine("Cake - " + cakeCount);
            Console.WriteLine("Bread - " + breadCount);
            Console.WriteLine("Suger - " + sugerCount);
            Console.WriteLine("Water - " + waterCount);
            Console.WriteLine("Banana - " + bananaCount);
            Console.WriteLine("Apple - " + appleCount);
            Console.WriteLine("Total price = " + totalPrice);
            if (totalPrice > buyer._cash)
            {
                Console.WriteLine("Not enough money! Return products!");
                foreach (Products p in buyer._productList)
                {
                    if (p is Milk)
                    {
                        milk.Enqueue(new Milk());
                        continue;
                    }

                    if (p is Cake)
                    {
                        cake.Enqueue(new Cake());
                        continue;
                    }

                    if (p is Bread)
                    {
                        bread.Enqueue(new Bread());
                        continue;
                    }
                    if (p is Suger)
                    {
                        suger.Enqueue(new Suger());
                        continue;
                    }
                    if (p is Water)
                    {
                        water.Enqueue(new Water());
                        continue;
                    }
                    if (p is Apple)
                    {
                        apple.Enqueue(new Apple());
                        continue;
                    }
                    if (p is Banana)
                    {
                        banana.Enqueue(new Banana());
                        continue;
                    }
                }
            }
            else
            {
                buyer._cash -= totalPrice;
                Console.WriteLine("Cash left: " + buyer._cash);
            }
        }
        public void ExpDateCount()
        {
            apple1.expDate--;
            banana1.expDate--;
            milk1.expDate--;
            bread1.expDate--;
            cake1.expDate--;
            suger1.expDate--;
            water1.expDate--;
        }
        public void StatisticForLooses()
        {
            int milkLoses = 0;
            int breadLoses = 0;
            int cakeLoses = 0;
            int sugerLoses = 0;
            int appleLoses = 0;
            int bananaLoses = 0;
            int waterLoses = 0;
            Console.WriteLine("STATISTICS BY LOSES");
            if (milk1.expDate < 1)
            {
                milkLoses = milk1.price * milk.Count;
                Console.WriteLine("Loses for milk: " + milkLoses + ". Lose amount: " + milk.Count);
            }
            if (bread1.expDate < 1)
            {
                breadLoses = bread1.price * bread.Count;
                Console.WriteLine("Loses for bread: " + breadLoses + ". Lose amount: " + bread.Count);
            }
            if (cake1.expDate < 1)
            {
                cakeLoses = cake1.price * cake.Count;
                Console.WriteLine("Loses for cakes: " + cakeLoses + ". Lose amount: " + cake.Count);
            }
            if (water1.expDate < 1)
            {
                waterLoses = water1.price * water.Count;
                Console.WriteLine("Loses for water: " + waterLoses + ". Lose amount: " + water.Count);
            }
            if (apple1.expDate < 1)
            {
                appleLoses = apple1.price * apple.Count;
                Console.WriteLine("Loses for apples: " + appleLoses + ". Lose amount: " + apple.Count);
            }
            if (banana1.expDate < 1)
            {
                bananaLoses = banana1.price * banana.Count;
                Console.WriteLine("Loses for bananas: " + bananaLoses + ". Lose amount: " + banana.Count);
            }
            if (suger1.expDate < 1)
            {
                sugerLoses = suger1.price * suger.Count;
                Console.WriteLine("Loses for suger: " + sugerLoses + ". Lose amount: " + suger.Count);
            }
            Console.WriteLine("Total loses for all period: " + (milkLoses + breadLoses + cakeLoses + sugerLoses + appleLoses + bananaLoses + waterLoses));
            Console.WriteLine("============================================");
        }
    }
}
