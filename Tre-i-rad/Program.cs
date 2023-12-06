
namespace Tre_i_rad
{
    public static class Program
    {
        public static int ActiveProgram = -1;

        static void Main(string[] args)
        {
            while (!Environment.HasShutdownStarted)
            {
                while (ActiveProgram == -1)
                {
                    MainMenu.RunProgram();
                    break;
                }
                Console.Clear();
                switch (ActiveProgram)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You chose to play the tic tac toe game.");
                        GameLogic.RunProgram();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You chose to go to settings");
                        Settings.RunProgram();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You chose to test the data structures");
                        TestMenu.RunProgram();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Exiting the program");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                ActiveProgram = -1;
            }
        }
    }

}