using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ///*PART ONE*/

            ////array of greetings in different languages
            //string[] greetings = { "Hello ", "Hola ", "Hallo " };

            ////Request user to input name, saves as 'userName'
            //Console.WriteLine("Please type you name.");
            //string userName = Console.ReadLine();

            ////Updates each element of greetings array with + userName
            //for (int i = 0; i < greetings.Length; i++)
            //    greetings[i] = greetings[i] + userName + "!";

            ////Writes each [] element to console
            //for (int i = 0; i < greetings.Length; i++)
            //    Console.WriteLine(greetings[i]);
            //Console.ReadLine();


            ///*PART TWO*/

            ////(Infinite) loop
            //bool loopKey = true;
            //while (loopKey)//If loopKey is true, loop
            //{
            //    Console.WriteLine("AAAHHHHHHHHHHHHHH!!!");
            //    loopKey = false;//fixes infinte loop
            //}
            //Console.ReadLine();


            ///*PART THREE*/

            ////Loop with < operator
            //int numMarker = 0;//Sets numMarker to 0 
            //while (numMarker < 6)//While numMarker is less than 6, loop
            //{
            //    Console.WriteLine(numMarker);//Prints numMarker to Console
            //    numMarker++;//Increments numMarker by +1
            //}
            //Console.ReadLine();

            ////Loop with <= operator
            //while (numMarker <= 10)//While numMarker is less than/equal to 10, loop
            //{
            //    Console.WriteLine(numMarker);
            //    numMarker++;
            //}
            //Console.ReadLine();


            ///*PART FOUR*/

            ////List of colors (11)
            //List<string> colors = new List<string>() { "black", "grey", "white", "brown", "red", "blue", "yellow", "purple", "green", "orange", "pink" };

            //Console.WriteLine("Check if your color is on the list. What is your color?");
            //string userColor = Console.ReadLine();//Saves user input as userColor
            //userColor = userColor.ToLower();//Converts userColor to lower case to accurately compare to list elements
            //string colorConfirm = "Your color is at index ";//Display message when color is found
            //bool colorFound = false;//sets colorFound to false to init do-while loop

            //do
            //{
            //    switch (userColor)//using string userColor to compare to cases
            //    {
            //        case "black"://List element
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));//if correct case, prints colorConfirm and concatenates with index of list element.
            //            colorFound = true;//sets colorFound to true to exit loop
            //            break;//breaks out of loop before checking next case

            //        case "grey":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "white":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "brown":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "red":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "blue":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "yellow":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "purple":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "green":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "orange":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        case "pink":
            //            Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
            //            colorFound = true;
            //            break;

            //        default://selected if userColor is not a part of colors
            //            Console.WriteLine("Your color is not on the list! Try another color.");//request for user to try another color
            //            userColor = Console.ReadLine();//saves new input as userColor
            //            userColor = userColor.ToLower();
            //            break;
            //    }
            //}
            //while (!colorFound);//colorFound must be false to enter while loop

            //Console.ReadLine();


            /*PART FIVE*/
            //Items on Kitchen Table (7) two identical elements "fork"[0] & "fork"[4] 
            List<string> tableItems = new List<string>() { "fork", "knife", "plate", "cup", "fork", "spoon", "napkin" };
            Console.WriteLine("These are the Items on my dinner table.\n");

            for (int i = 0; i < tableItems.Count; i++)
            {
                Console.WriteLine("\t" + tableItems[i]);
            }

            List<string> itemIndecies = new List<string>();
            Console.WriteLine("\nWhich item would you like to select?");
            string userItem = Console.ReadLine();
                   userItem = userItem.ToLower();


            foreach (string item in tableItems)
            {
                if (userItem == item)
                {
                    int index = tableItems.IndexOf(userItem);
                    Console.WriteLine("That item is at index " + index);

                }
                else
                {
                    Console.WriteLine("That item is not on the table.");
                    break;
                }
            }
            
            Console.ReadLine();


            /*PART SIX*/

        }
    }
}
