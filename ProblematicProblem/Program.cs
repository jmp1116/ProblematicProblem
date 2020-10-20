using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Threading;


namespace ProblematicProblem
{
    class Program
    {


        
        static Random rng;
        static bool cont = true;
        static bool seeList = false;
        static bool addToList = false;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {

           
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "no") 
            {
                Console.WriteLine("OK, well thanks anyways!");
                System.Environment.Exit(0);
            }

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? yes/no: ");
            string answer1 = Console.ReadLine().ToLower();

            if (answer1 == "yes") { seeList = true; }
            Console.WriteLine();

            if (seeList == true)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                string answer2 = Console.ReadLine();
                if (answer2 == "yes") { addToList = true; }
                Console.WriteLine();

                while (addToList == true)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    string answer3 = Console.ReadLine();
                    if (answer3 == "no") { addToList = false; }
                    Console.WriteLine();
                }
            }

            while (cont == true)
            {
                Console.Write("Connecting to the database");


                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                int counter = activities.Count;
                var rand = new Random();
                int randomNumber = rand.Next(counter);

                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {


                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);
                }

                    int randomNumber2 = rand.Next(counter);

                    Console.WriteLine($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? yes/no: ");
                    string answer4 = Console.ReadLine().ToLower();
                    if (answer4 == "no") { cont = false; }
                
            } 
            
        }
    }

    
    



  
}
