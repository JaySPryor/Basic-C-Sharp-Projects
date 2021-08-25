using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jaymes", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Jaymes")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}

        ////To print whole array to console:
        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}
        //Console.ReadLine();


        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(78);
        //testScores.Add(86);
        //testScores.Add(85);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {   
        //        Console.WriteLine("Passing test Score: " + score);
        //    } 
        //}
        //Console.ReadLine();

        /*
        List<string> names = new List<string> { "Jaymes", "Erik", "Adam", "Daniel" };

        foreach (string name in names)
        {   
            ////to print 1 item in list
            //if (name == "Jaymes")
            //{   
            //    Console.WriteLine(name);
            //}

            //to print all items in list
            Console.WriteLine(name);
        }
        */

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);

        Console.ReadLine();
    }
}

