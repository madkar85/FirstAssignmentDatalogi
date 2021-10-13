using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstAssignmentDatalogi
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        /// <summary>
        /// Startmetod för programmet innehållande menyn
        /// </summary>
        public static void Start() 
        {
            Console.WriteLine("Hello!");
            
            bool keepGoing = true;
            var primeNumbers = new List<int>();

            while (keepGoing)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a number");
                Console.WriteLine("2. Print all numbers added");
                Console.WriteLine("3. Add next prime number");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddInput(primeNumbers);
                        break;
                    case "2":
                        PrintList(primeNumbers);
                        break;
                    case "3":
                        AddNextPrime(primeNumbers);
                        break;
                    case "4":
                        keepGoing = false;
                        break;
                    default:
                        ErrorMessage();
                        break;
                }
            }
        }

        /// <summary>
        /// Tar emot input där vi frågar efter en siffra
        /// </summary>
        public static void AddInput(List<int> primeNumbers)
        {
            Console.WriteLine("Please type a number: ");
            string answer = Console.ReadLine();
            CheckIfCorrectInput(primeNumbers, answer);
        }

        /// <summary>
        /// Kollar om inputen är en siffra som vi förväntat oss
        /// </summary>
        /// <param name="answer"></param>
        public static void CheckIfCorrectInput(List<int> primeNumbers, string answer)
        {
            bool isNumber = int.TryParse(answer, out int i);

            if (isNumber)
            {
                var isPrime = CheckIfPrimeNumber(i);

                if (isPrime)
                {
                    AddToList(primeNumbers, i);
                }
                else
                {
                    Console.WriteLine("This is not a prime number");
                }
            }
            else
            {
                ErrorMessage();
            }

        }

        /// <summary>
        /// Kollar om siffran är ett primtal, annars skrivs ett meddelande ut
        /// Hoppar över nr 1 då allt är delbart med det 
        /// </summary>
        /// <param name="number"></param>
        public static bool CheckIfPrimeNumber(int number)
        {
            if (number <= 1) return false;

            var isPrime = false;

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = (i == number);

                    break;
                }
            }

            return isPrime;
        }

        /// <summary>
        /// Lägger till primtalet i en lista
        /// </summary>
        /// <param name="i"></param>
        public static void AddToList(List<int> primeNumbers, int i)
        {
            primeNumbers.Add(i);
        }

        /// <summary>
        /// Skriver ut ett felmeddelande vid fel typ av input
        /// </summary>
        public static void ErrorMessage()
        {
            Console.WriteLine("The input is incorrect, pleace try again.");
        }

        /// <summary>
        /// Räknar ut nästa primtal utifrån inputsiffran
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <returns></returns>
        public static int GetNextPrime(int currentNumber)
        {
            bool foundPrime = false;

            while (!foundPrime)
            {
                currentNumber++;
                foundPrime = CheckIfPrimeNumber(currentNumber);
            }

            return currentNumber;
        }

        /// <summary>
        /// Räknar ut högsta primtalet i listan och 
        /// lägger till nästa primtal
        /// </summary>
        /// <param name="list"></param>
        public static void AddNextPrime(List<int> list)
        {
            var sortedList = SortList(list);

            var highestPrime = sortedList.Last();

            var nextPrime = GetNextPrime(highestPrime);

            AddToList(list, nextPrime);
        }

        /// <summary>
        /// Sorterar en lista i storleksordning
        /// </summary>
        /// <param name="list"></param>
        public static List<int> SortList(List<int> list)
        {
            var sortedList = new List<int>(list);

            sortedList.Sort();

            return sortedList;
        }

        /// <summary>
        /// Skriver ut listan med primtal
        /// </summary>
        public static void PrintList(List<int> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
