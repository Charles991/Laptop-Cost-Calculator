using System;

namespace CanterburyComputers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model;
            int noOflaptops;
            decimal laptopPrice = 0;
            decimal totalCost;
            string upgrade;
           
            Console.WriteLine("Hello! What computer model would you like? 'D', 'L' or 'A'");
            model = Console.ReadLine();

            Console.WriteLine("How many computers would you like to order?");
            noOflaptops = int.Parse(Console.ReadLine());

            Console.WriteLine("Finally would you like to upgrade to the deluxe package? Please enter Y (yes) or N (no)");
            upgrade = Console.ReadLine();

            switch (model)
            {
                case "D":
                    laptopPrice = 2800M;
                    if (upgrade == "Y")
                    {
                        laptopPrice = 3000M;
                    }
                    break;

                case "L":
                    laptopPrice = 1700M;
                    if (upgrade == "Y")
                    {
                        laptopPrice = 2000M;
                    }
               
                    break;
                
                case "A":
                    laptopPrice = 2200M;
                   if (upgrade == "Y")
                    {
                        laptopPrice = 2500M;
                    }
                    break;
            }

          

            totalCost = laptopPrice * noOflaptops;

            if (noOflaptops >=10 )
            {
                totalCost = totalCost * 0.85M;
            }
            else if(noOflaptops >=3)
            {
                totalCost = totalCost * 0.9M;
            }

            Console.WriteLine("Your total price is £" + totalCost);
        }
    }
}
