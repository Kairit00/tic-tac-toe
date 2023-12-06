using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    internal class Player : IPlayer
        //                          Spelarens klass
    {
        bool recentUndo = false;

        public void MakeMove(string player, string[] activeBoard, List<int> legalMoves)
        {
            int playerMove = -1;
            bool isLegal = false;
            

            Console.WriteLine("\nWhat move would you like to make? Enter a number 0-8. Press 'E' to undo your latest move.");
            var input = Console.ReadLine().ToUpper();


            //          Om spelaren väljer att göra en undo
            if (input == "E")
            {
                if (recentUndo == false) 
                {
                    recentUndo = true;
                    Board.UndoMove();
                    Board.Display();
                }
                else
                {
                    // Ogiltigt drag
                    Console.WriteLine("\nYou can't undo two times in a row!");
                }
                Console.WriteLine("\nWhat move would you like to make? Enter a number 0-8.");
                input = Console.ReadLine();
            }
            else
            {
                recentUndo = false;
            }


            while (!isLegal)
            {
                //     Läser av spelarens val

                playerMove = int.Parse(input);
                for (int i = 0; i < Game.LegalMoves.Count; i++)
                {
                    if (playerMove == Game.LegalMoves[i]) isLegal = true;
                }

                //     Ogiltig drag
                if (isLegal == false)
                {
                    Console.WriteLine("\nNot a valid move! Try again!");
                    input = Console.ReadLine();
                }
            }

            //              Spelarens drag läggs till på planen
            Board.Add(playerMove, player);
            Board.Display();
        }
    }
}
