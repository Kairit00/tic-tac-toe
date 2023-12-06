using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    public class GameLogic
    {
        //                      Denna klass tar hand om själva spelet i en loop och tar hand om spelarnas speldrag. 
        public static void RunProgram()
        {
            //          Variabler så att spelet fungerar
            {
                CPU ai = new();
                Board b = new();
                Player human = new();

                string cpu;
                string player;

                //                  Välja spelsymbol
                Console.WriteLine("Choose to play as 'X' or 'O':");
                player = Console.ReadLine().ToUpper();

                if (player == "X") cpu = "O";
                else cpu = "X";

                Board.Display();

                //                      Loopen för spelet, den loopar tills någon har vunnit eller om det är oavgjort
                while (!Game.CheckWin(player, b.ActiveBoard) && !Game.CheckDraw(player, b.ActiveBoard))
                {
                    human.MakeMove(player, b.ActiveBoard, Game.LegalMoves);
                    Game.LegalMoves = Board.CheckLegalMoves();

                    if (Game.CheckWin(player, b.ActiveBoard) || Game.CheckDraw(player, b.ActiveBoard)) break;
                    else
                    {
                        ai.MakeMove(cpu, b.ActiveBoard, Game.LegalMoves);
                        Game.LegalMoves = Board.CheckLegalMoves();
                    }

                }

                //                      När någon har vunnit så gör spelet ett reset och går tillbaka till huvudmenyn
                Board.Reset();
                Console.WriteLine("\nPress any key to continue:");
                Console.ReadLine();
            }
        }
    }
}
