using System;
using System.Collections.Generic;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of string data
            string[] complimentArray = { "You found the secret! You're so smart!", "Nice Shirt!", "You have beautiful eyes!", "You've got a great smile!", "I like your shoes!", "You're awesome!" };

            //Array of integer data
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List of string data
            List<string> stringList = new List<string>();
            stringList.Add("Me too!");
            stringList.Add("I'm sorry. Let's go for a walk!");
            stringList.Add("I'm sorry. Let's take a nap!");

            //Title & first Question
            Console.WriteLine("Welcome to the Compliment Generator 1.0! \nPick anumber from 1 to 5.");
            int answer1 = Convert.ToInt32(Console.ReadLine());//User inputs 1-5

            //Selected if answer1 is < 6
            if (answer1 < 6)
            {   
                //Second Question
                Console.WriteLine(complimentArray[answer1] + "\n\nWhat's your favorite number, from 0 to 10?"); ;
                int answer2 = Convert.ToInt32(Console.ReadLine());//User inputs 0-10

                //Selected if answer2 is < 11
                if (answer2 < 11)
                {   
                    //Third Question
                    Console.WriteLine(numArray[answer2] + " Is a great number! \n\nHow did you like those games? \n0. I had fun! \n1. I'm bored. \n2. I'm sad now.");
                    int answer3 = Convert.ToInt32(Console.ReadLine());//User inputs 0-2
                    
                    //Selected if answer3 is < 4
                    if (answer3 < 4)
                    {
                        Console.WriteLine(stringList[answer3]);
                        Console.ReadLine();
                    }
                    //Selected if answer3 is > 3
                    else
                    {
                        Console.WriteLine("You entered the wrong number!");
                        Console.ReadLine();
                    }

                }
                //Selected if answer2 is > 10
                else
                {
                    Console.WriteLine("You entered the wrong number!");
                    Console.ReadLine();
                }
            }
            //Selected if answer1 is > 5
            else
            {
                Console.WriteLine("You entered the wrong number!");
                Console.ReadLine();
            }



        }
    }
}
