using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tre_i_rad.DataStructure;

namespace Tre_i_rad
{
    public class TestMenu
    {
        static BaseDatastructure? testDataStructure;

        public static void RunProgram()
        {
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("#---------------------------------------------#");
                Console.WriteLine("# What Data Structure would you like to test? #");
                Console.WriteLine("#---------------------------------------------#");
                Console.WriteLine("#  [1] - Stack                                #");
                Console.WriteLine("#  [2] - Linked List                          #");
                Console.WriteLine("#  [3] - Exit                                 #");
                Console.WriteLine("#---------------------------------------------#");

                int input;
                int count = 0;
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        testDataStructure = new StackDatastructure();

                        Console.Clear();
                        Console.WriteLine("You chose Stack! Choose a number 1 - 10:");

                        input = int.Parse(Console.ReadLine());
                        for (int i = 0; i < input; i++)
                        {
                            testDataStructure.Add(RandomBoard());
                        } 

                        Console.WriteLine($"\nYou added {input} random board to the Stack, now it looks like this:");
                        
                        for (int i = 0; i < input; i++)
                        {
                            DisplayBoard(testDataStructure.GetLast());
                            testDataStructure.RemoveLast();
                        }
                        Console.WriteLine("\nDue to the nature of Stack, the data was deleted when showing all the boards!");
                        break;
                    case "2":
                        Console.Clear();
                        testDataStructure = new LinkedListDatastructure();

                        Console.Clear();
                        Console.WriteLine("You chose LinkedList! Choose a number 1 - 10:");

                        input = int.Parse(Console.ReadLine());
                        for (int i = 0; i < input; i++)
                        {
                            testDataStructure.Add(RandomBoard());
                            count++;
                        }

                        Console.WriteLine($"\nYou added {input} random board to the LinkedList, now it looks like this:");

                        for (int i = 0; i < input; i++)
                        {
                            DisplayBoard(testDataStructure.GetAtIndex(i));
                        }

                        Console.WriteLine("\nChoose number of boards to remove:");
                        input = int.Parse(Console.ReadLine());
                        for (int i = 0; i < input; i++)
                        {
                            testDataStructure.RemoveLast();
                            count--;
                        }

                        Console.WriteLine($"\nYou removed {input} boards from the LinkedList, now it looks like this:");

                        for (int i = 0; i < count; i++)
                        {
                            DisplayBoard(testDataStructure.GetAtIndex(i));
                        }

                        break;
                    case "3":
                        Console.Clear();
                        exit = true;
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;
                }
                Console.WriteLine("\nPress any key to continue:");
                Console.ReadLine();
            } while (!exit);
        }

        public static void DisplayBoard(string[] board)
        {
            Console.WriteLine("\n|" +board[0] + "|" + board[1] + "|" + board[2] + "|");
            Console.WriteLine("|" + board[3] + "|" + board[4] + "|" + board[5] + "|");
            Console.WriteLine("|" + board[6] + "|" + board[7] + "|" + board[8] + "|");
        }   

        public static string[] RandomBoard()
        {
            int num;
            string[] randomBoard = { "", "", "", "", "", "", "", "", "" };

            for (int i = 0; i < 9; i++)
            {
                Random rnd = new Random();
                num = rnd.Next(3);

                if (num == 0)
                {
                    randomBoard[i] = "_";
                }
                else if (num == 1) 
                {
                    randomBoard[i] = "X";
                }
                else
                {
                    randomBoard[i] = "O";
                }
            }

            return randomBoard;
        }
    }
}
