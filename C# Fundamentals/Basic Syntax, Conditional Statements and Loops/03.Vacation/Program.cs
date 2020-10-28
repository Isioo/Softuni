using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGroup = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            totalPrice = countOfGroup * price;
            if (typeOfGroup == "Students" && countOfGroup >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (typeOfGroup == "Business" && countOfGroup >= 100)
            {
                totalPrice -= 10 * price;
            }
            else if (typeOfGroup == "Regular" && countOfGroup >= 10 && countOfGroup <= 20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
