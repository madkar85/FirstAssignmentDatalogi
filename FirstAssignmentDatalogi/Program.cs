using System;
using System.Collections.Generic;

namespace FirstAssignmentDatalogi
{
    public class Program
    {
        //Användare ska skicka in valfritt värde                                            OK
        //Utvärdera som värdet är ett primtal                                               OK
        //Om det är ett primtal, lägg till i en lista eller liknande datastruktur           OK
        //Ska gå att skriva ut hela datastrukturen i konsolen
        //Kunna på kommando lägga till nästa primtal utifrån det högsta i listan
        //Programmet avslutas när användaren bestämmer det.                                 OK
        //Programmet ska kunna ta emot all form av input och hantera det.                   OK
        //Tex felmeddelande vid felaktig input och sedan ny chans att skriva in en input    OK
        //Kommentarer för hela programmet

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

            while (keepGoing)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a number");
                Console.WriteLine("2. Print all numbers added"); 
                Console.WriteLine("3. Add next prime number");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddInput();
                        break;
                    case "2":
                        PrintList();
                        break;
                    case "3":
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
        public static void AddInput()
        {
            Console.WriteLine("Please type a number: ");
            string answer = Console.ReadLine();
            CheckIfCorrectInput(answer);
        }

        /// <summary>
        /// Kollar att inputen är en siffra
        /// </summary>
        /// <param name="answer"></param>
        public static void CheckIfCorrectInput(string answer)
        {
            bool isNumber = int.TryParse(answer, out int i);

            if (isNumber)
            {
                var isPrime = CheckIfPrimeNumber(i);

                if (isPrime)
                {
                    AddToList(i);
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
        /// Bryter loopen tidigt för att 
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
        public static void AddToList(int i)
        {
            List<int> list = new List<int>();
            list.Add(i);
            Console.WriteLine("This is a prime number");

        }

        /// <summary>
        /// Skriver ut ett felmeddelande vid fel typ av input
        /// </summary>
        public static void ErrorMessage()
        {
            Console.WriteLine("The input is incorrect, pleace try again.");
        }

        /// <summary>
        /// Skriver ut listan med primtal
        /// </summary>
        public static void PrintList()
        {
            /*
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            */
            Console.WriteLine("Funkar");
        }
        
    }

}
