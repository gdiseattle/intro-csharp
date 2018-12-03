using System;

namespace gdi
{
    class PizzeriaProcessing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numberOfPizzas;
            int maxNumberOfPizzas = 2;
            bool isOrderFull = false;
            double orderCost = 0;

            numberOfPizzas = 1;
            maxNumberOfPizzas = maxNumberOfPizzas + 1;
            numberOfPizzas++;
            Console.WriteLine("Number of Pizzas: " + numberOfPizzas);

            orderCost = orderCost + 13;
            Console.WriteLine("Cost of the order is: " + orderCost);
            orderCost = orderCost / 2;
            Console.WriteLine("Cost of the order is: " + orderCost);

            isOrderFull = (numberOfPizzas == maxNumberOfPizzas);
            Console.WriteLine("The order is full: " + isOrderFull);

            bool hasSpace = numberOfPizzas < maxNumberOfPizzas;
            Console.Write("\nWe have less than the number of max pizzas: "
            + hasSpace);
            isOrderFull = numberOfPizzas > maxNumberOfPizzas;
            Console.Write("\nI'm full! " + isOrderFull);

            bool isEmptyOrder = orderCost <= 0 && numberOfPizzas <= 0;
            Console.WriteLine("\nOrder is empty: " + isEmptyOrder);

            bool largeOrder = isOrderFull || orderCost >= 50;
            Console.WriteLine("\nAlert! Large order incoming: " + largeOrder);

            switch (numberOfPizzas)
            {
                case 0:
                    Console.Write("\nYou haven't added a pizza to your order");
                    break;
                case 1:
                    Console.Write("\nDinner for one?");
                    break;
                case 2:
                    Console.Write("\nHaving a couple of guests over?");
                    break;
                case 3:
                    Console.Write("\nYou've reached the pizza limit!");
                    break;
                default:
                    Console.Write("\nPizza time!");
                    break;
            }

            for (orderCost = 0; orderCost < 50; orderCost += 10) {
                Console.Write("\nMy order costs $" + orderCost + "!");
            }

            isOrderFull = numberOfPizzas == maxNumberOfPizzas;
            Console.Write("\nOur max number of pizzas is " + maxNumberOfPizzas);

            while (!isOrderFull)
            {
                /* We'll add a pizza */
                numberOfPizzas++;
                /* We'll alert how many pizzas we have */
                Console.Write("\nI'm carrying: " + numberOfPizzas);
                /* We'll update whether or not we're full */
                isOrderFull = numberOfPizzas == maxNumberOfPizzas;
            }

            string[] consoles = new string[3];
            consoles[0] = "PS4";
            consoles[1] = "Xbox";
            consoles[2] = "Switch";

            for (int i = 0; i < consoles.Length; i++) {
                Console.Write("\nConsole " + i + " is " + consoles[i]);
            }

            string newConsole = new string("Sega Genesis");
            Console.Write("\nLength: " + newConsole.Length);
            Console.Write("\nDoes the word contain 'genesis'? " +
                newConsole.Contains("genesis"));
            string lowerCaseConsole = newConsole.ToLower();
            Console.Write("\nIt's all lower " + lowerCaseConsole);
            Console.Write("\nDoes the word contain 'genesis'? " +
                lowerCaseConsole.Contains("genesis"));

            Console.Write("It's all upper " + newConsole.ToUpper());

        }
    }
}
