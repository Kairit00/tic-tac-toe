using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    public class MainMenu
        //                      Hur själva huvudmenyn ser ut
    {
        private static readonly Predicate<int> Invalidator = i => i is < 1 or > 4;
        public static void RunProgram()
        {
            {
                Console.Clear();
                Console.WriteLine("#------------------------------------------#");
                Console.WriteLine("#     Please choose your options below     #");
                Console.WriteLine("#------------------------------------------#");
                Console.WriteLine("#  [1] - Play the tic tac toe game         #");
                Console.WriteLine("#  [2] - Settings                          #");
                Console.WriteLine("#  [3] - Test Data Stuctures               #");
                Console.WriteLine("#  [4] - Exit                              #");
                Console.WriteLine("#------------------------------------------#");

                Console.Write("Option: ");
                var input = Util.ReadLine<int?>();

                while (input == null || Invalidator(input.Value))
                {
                    Console.WriteLine("Invalid Input, Number should be between 1 and 4");
                    Console.Write("Option: ");
                    input = Util.ReadLine<int?>();
                }

                Program.ActiveProgram = input.Value;

            }
     
        }
    }
}
