using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            // var lWords = from elements in fruits
            //     where elements[0] == 'L'
            //     select elements;
            //     foreach (string word in lWords)
            //     {
            //         Console.WriteLine(word);
            //     }

            // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);
            // foreach (int number in fourSixMultiples)
            // {
            //     Console.WriteLine(number);
            // }   

            // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            // List<string> descent = names.OrderByDescending (name => name).ToList ();
            // foreach (var name in descent) 
            // {
            //     Console.WriteLine(name);
            // }

            // Build a collection of these numbers sorted in ascending order
            // List<int> numbers = new List<int>()
            //     {
            //         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //     };

            // List<int> ascend = numbers.OrderBy (number => number).ToList ();
            // foreach (var number in ascend)
            // {
            //     Console.WriteLine(number);
            // }

            // Output how many numbers are in this list
            // List<int> numbers = new List<int>()
            //     {
            //         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //     };

            // int numberCount = numbers.Count;
            // Console.WriteLine(numberCount);

            // How much money have we made?
            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };
            // double sumPurchases = purchases.Sum();
            // Console.WriteLine($"The sum of all purchases is ${sumPurchases:N2}");

            // What is our most expensive product?
            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };
            // Console.WriteLine($"The highest priced item cost ${prices.Max()}");

            // List<int> wheresSquaredo = new List<int>()
            // {
            //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            // };

            // var notSquare = wheresSquaredo.TakeWhile(num => 
            // {
            //     return num % Math.Sqrt(num) != 0;
            // });

            // foreach (var num in notSquare)
            // {
            //     Console.WriteLine(num);
            // };
            // Build a collection of customers who are millionaires
        
            var customers = new List<Customer> () {
                new Customer () { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer () { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer () { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer () { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer () { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer () { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer () { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer () { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer () { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer () { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }

            };
            var millionaireCustomers = customers.Where(customer => customer.Balance >= 1000000);

            var millionaireGroups = millionaireCustomers.GroupBy(customer => customer.Bank).Select (group => 
            {
                return new BankReport
                {
                    MillionaireCount = group.Count(),
                    BankName = group.Key
                };
            });

            foreach (var mill in millionaireGroups)
            {
                Console.WriteLine($"{mill.BankName}: {mill.MillionaireCount}");
            }
            
        }
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        public class BankReport
        {
            public int MillionaireCount { get; set; }
            public string BankName { get; set; }
        }
    }
}
