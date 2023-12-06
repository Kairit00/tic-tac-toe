using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    public class Settings
        //                      Våra färginställningar 
    {
        public static void RunProgram()
        {
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Here is the settings! Choose what you want to do: ");
                Console.WriteLine("#------------------------------------------#");
                Console.WriteLine("#     Please choose your options below     #");
                Console.WriteLine("#------------------------------------------#");
                Console.WriteLine("#  [1] - White background, black text      #");
                Console.WriteLine("#  [2] - Black bacground, white text       #");
                Console.WriteLine("#  [3] - Blue background, black text       #");
                Console.WriteLine("#  [4] - Exit                              #");
                Console.WriteLine("#------------------------------------------#");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    //              Vit bakgrund, svart text
                    case "1":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.Clear();
                        Console.WriteLine("This is now your setting!");
                        break;
                    //              Svart bakgrund, vit text (default)
                    case "2":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Clear();
                        Console.WriteLine("This is now your setting!");
                        break;
                    //              Blå bakgrund, svart text
                    case "3":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.Clear();
                        Console.WriteLine("This is now your setting!");
                        break;

                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. PLease try again!");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (!exit);
        }
    }
}
