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

            /*PART ONE*/

            //array of greetings in different languages
            string[] greetings = { "Hello ", "Hola ", "Hallo " };

            //Request user to input name, saves as 'userName'
            Console.WriteLine("Please type you name.");
            string userName = Console.ReadLine();

            //Updates each element of greetings array with + userName
            for (int i = 0; i < greetings.Length; i++)
                greetings[i] = greetings[i] + userName + "!";

            //Writes each [] element to console
            for (int i = 0; i < greetings.Length; i++)
                Console.WriteLine(greetings[i]);
            Console.ReadLine();


            /*PART TWO*/

            //(Infinite) loop
            bool loopKey = true;
            while (loopKey)//If loopKey is true, loop
            {
                Console.WriteLine("AAAHHHHHHHHHHHHHH!!!");
                loopKey = false;//fixes infinte loop
            }
            Console.ReadLine();


            /*PART THREE*/

            //Loop with < operator
            int numMarker = 0;//Sets numMarker to 0 
            while (numMarker < 6)//While numMarker is less than 6, loop
            {
                Console.WriteLine(numMarker);//Prints numMarker to Console
                numMarker++;//Increments numMarker by +1
            }
            Console.ReadLine();

            //Loop with <= operator
            while (numMarker <= 10)//While numMarker is less than/equal to 10, loop
            {
                Console.WriteLine(numMarker);
                numMarker++;
            }
            Console.ReadLine();


            /*PART FOUR*/

            //List of colors (11)
            List<string> colors = new List<string>() { "black", "grey", "white", "brown", "red", "blue", "yellow", "purple", "green", "orange", "pink" };

            Console.WriteLine("Check if your color is on the list. What is your color?");
            string userColor = Console.ReadLine();//Saves user input as userColor
            userColor = userColor.ToLower();//Converts userColor to lower case to accurately compare to list elements
            string colorConfirm = "Your color is at index ";//Display message when color is found
            bool colorFound = false;//sets colorFound to false to init do-while loop

            do
            {
                switch (userColor)//using string userColor to compare to cases
                {
                    case "black"://List element
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));//if correct case, prints colorConfirm and concatenates with index of list element.
                        colorFound = true;//sets colorFound to true to exit loop
                        break;//breaks out of loop before checking next case

                    case "grey":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "white":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "brown":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "red":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "blue":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "yellow":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "purple":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "green":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "orange":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    case "pink":
                        Console.WriteLine(colorConfirm + colors.IndexOf(userColor));
                        colorFound = true;
                        break;

                    default://selected if userColor is not a part of colors
                        Console.WriteLine("Your color is not on the list! Try another color.");//request for user to try another color
                        userColor = Console.ReadLine();//saves new input as userColor
                        userColor = userColor.ToLower();
                        break;
                }
            }
            while (!colorFound);//colorFound must be false to enter while loop

            Console.ReadLine();


            /*PART FIVE*/
            //Items on Kitchen Table (7) two identical elements "fork"[0] & "fork"[4] 
            List<string> tableItems = new List<string>() { "fork", "knife", "plate", "cup", "fork", "spoon", "napkin" };
            Console.WriteLine("These are the Items on my dinner table.\n");
            //loop that iterates the contents of tableItems
            for (int i = 0; i < tableItems.Count; i++)
            {
                Console.WriteLine("\t" + tableItems[i]);//Prints list elements to console
            }

            Console.WriteLine("\nWhich item would you like to select?");
            string userItem = Console.ReadLine();//saves user input to userItem
            userItem = userItem.ToLower();//changes userItem to all lower case

            for (int i = 0; i < tableItems.Count; i++)//Loop that searches through list, prints message for each element
            {
                if (userItem == tableItems[i])//selected if userItem matches the current index value
                {
                    Console.WriteLine(userItem + " was found in index " + i);//prints userItem with matching index
                }
                else//selected if userItem does not match current index value
                {
                    Console.WriteLine("That item was not found in index " + i);//Prints message stating that userItem is not in current index
                }
            }

            Console.ReadLine();


            /*PART SIX*/
            //List of bands (4) with two identical elements
            List<string> bands = new List<string>() { "elvis", "elvis", "poison", "ac/dc" };
            List<string> duplicateBands = new List<string>();//empty list for holding/comparing elements

            foreach (string band in bands)//Loop that checks each element of bands list
            {
                //Selected if duplicateBands already contains current band
                if (duplicateBands.Contains(band))
                {
                    Console.WriteLine("The list contains more than one " + band + ".");
                }
                //Selceted if duplicateBands does not already contain current band
                else
                {   
                    Console.WriteLine("The list contains " + band + ".");
                }
                //Adds current band to duplicateBands list
                duplicateBands.Add(band);
            }

            Console.ReadLine();

        }
    }
}
