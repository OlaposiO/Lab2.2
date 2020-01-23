using System;

namespace Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNum = true;
            int userNumber = 0;
            bool validNum = false;
            bool doAgain = true;
            bool comeAgain = true;


            do
            {
                Console.WriteLine("Welcomes to the Powers tutor!");
                Console.Write("Please enter a positive number as a finishing point to get its square and cube: ");                                       
                
                do
                {
                    do
                    {

                        string userInput = Console.ReadLine();
                        isNum = int.TryParse(userInput, out userNumber);
                   


                        if (isNum == true)
                        {

                            if ((userNumber <= 1290) && (userNumber > 0))
                            {
                                validNum = true;
                                Console.WriteLine("\t Here is your Powers table");
                                Console.WriteLine($"Your finishing point is: {userNumber}");
                                Console.WriteLine(" \t Sqaures \t Cubes");
                                for (int i = 1; i <= userNumber; i++)
                                {
                                    int cubedNum = i * i * i;
                                    int sqauresNum = i * i;
                                    Console.WriteLine($"{i}:\t {sqauresNum}\t\t {cubedNum} ");

                                }
                            }
                            else if (userNumber < 0)
                            {
                                Console.WriteLine("Please enter a postive number.");
                                validNum = false;

                            }
                            else
                            {
                                Console.WriteLine("please enter a smaller number.");
                                validNum = false;
                            }
                            ////} while (true);

                        }
                        else
                        {
                            isNum = false;
                            Console.WriteLine("Please enter a valid number!");
                        }
                    } while (isNum == false);
                } while (validNum == false);

                
                do
                {

                    Console.WriteLine("Would you ike to try again? Yes or No"); 
                    string doAgainInput = Console.ReadLine().ToLower();

                    if ((doAgainInput == "yes") || (doAgainInput == "y"))
                    {
                        doAgain = true;
                        comeAgain = false;
                    }
                    else if ((doAgainInput == "no") || (doAgainInput == "n"))
                    {
                        doAgain = false;
                        comeAgain = false;
                        Console.WriteLine("Have a great day");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("I am sorry. I did not understand that.");
                        comeAgain = true;
                    }
                } while (comeAgain == true);
            } while (doAgain == true);

        }
    }
}
