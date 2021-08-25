using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Lists
            /*Most often used, in stead of Arrays.*/

        List<string> stringList = new List<string>();//List String
        stringList.Add("Hello");
        stringList.Add("Jaymes");
        stringList.Remove("Jaymes");

        List<int> intList = new List<int>();//List Int
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        ////Arrays
        //  /*Use arrays when dealing with a fixed quantity of something,
        //  or when storing a very large quantity of something, */

        //int[] numArray = new int[5];//Original way to make an int array
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };//faster way

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };//fastest way

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

    }
}
