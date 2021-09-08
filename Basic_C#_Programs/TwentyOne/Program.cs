using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using VirtualCasino;
using VirtualCasino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set Casino name to a constant 
            const string casinoName = "The virtual casino";

            //First greeting
            Console.WriteLine("Welcom to {0}! What's your name?", casinoName);
            string playerName = Console.ReadLine();//saves player name

            //
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            //block used to catch any exceptions(format exceptions)
            bool validAnswer = false;
            int bank = 0;
            //while validAnswer is false...
            while (!validAnswer)
            {
                Console.WriteLine("How many credits are you playing with today?");//ask for player to input credit amount
                validAnswer = int.TryParse(Console.ReadLine(), out bank);//use TryParse to return bool, and out credit (bank) amount
                if (!validAnswer) Console.WriteLine("Please enter digits only and no decimals.");//if still !validAnswer, clarify and repeat loop
            }

            //Asks if user wants to play a game
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();//saves answer to lowercase
            
            //creates player using input data, and creates game
            if (answer == "yes" || answer == "y")
            {
                

                //player object
                Player player = new Player(playerName, bank);
                //Create GUID for new player
                player.Id = Guid.NewGuid();

                //Log GUID to text file
                using (StreamWriter file = new StreamWriter(@"D:\School\GitHub\Basic-C-Sharp-Projects\Basic_C#_Programs\TwentyOne\Logs\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(player.Id);
                }

                //new TwentyOneGame, uses polymorphism
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlayer = true;

                //while player is active & has a positive balance
                while(player.isActivePlayer && player.Balance > 0)
                {
                    //Main game is wrapped in try/catch block to catch any exceptions & display error messages
                    try
                    {
                        //Main game
                        game.Play();
                    }
                    catch (FraudException ex)//exception used when someone is suspected of trying to cheat
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occured! Please contact the administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;//removes player if they exit while loop
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Bye for now.");//goodbye message
            Console.ReadLine();
        }
        //Private Method for logging exceptions
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial 
                                        Catalog=TwentyOneGame;Integrated Security=True;Connect 
                                        Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        
        //Method that will read past exceptions from Exceptions table(database)
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial 
                                        Catalog=TwentyOneGame;Integrated Security=True;Connect 
                                        Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
