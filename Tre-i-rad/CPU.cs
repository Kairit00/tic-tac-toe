using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    public class CPU : IPlayer
    {
        //                                       CPU:s klass
        public void MakeMove(string player, string[] activeBoard, List<int> legalMoves)
        {
            int cpuMove;
            bool isLegal = false;

            cpuMove = CheckThreat(player, activeBoard, legalMoves);

            if (cpuMove == -1)
            {
                //    Slumpmässigt drag
                while (!isLegal)
                {
                    Random rnd = new Random();
                    cpuMove = rnd.Next(9);
                    for (int i = 0; i < Game.LegalMoves.Count; i++)
                    {
                        if (cpuMove == Game.LegalMoves[i]) isLegal = true;
                    }
                }
            }

            // Lägger till cpu:ns drag på spelplanen
            Console.WriteLine("\nYour opponent has made their move!");
            Board.Add(cpuMove, player);
            Board.Display();
        }

        //                  Upptäcka Threats på spelplanen, göra CPU:n svårare
        private static int CheckThreat(string player, string[] activeBoard, List<int> legalMoves) 
        {
            int cpuMove = -1;
            List<int> potentialMoves = new List<int>();
            //          Blockera spelaren ifall man har lagt 2 i rad
            
            if ((activeBoard[1] == activeBoard[2] && activeBoard[1] !="_" && legalMoves.Contains(0)) || (activeBoard[3] == activeBoard[6] && activeBoard[3] !="_" && legalMoves.Contains(0)) || (activeBoard[4] == activeBoard[8] && activeBoard[4] !="_" && legalMoves.Contains(0)))
            {
                potentialMoves.Add(0);
            }
            else if ((activeBoard[0] == activeBoard[2] && activeBoard[0] !="_" && legalMoves.Contains(1)) || (activeBoard[4] == activeBoard[7] && activeBoard[4] !="_" && legalMoves.Contains(1)))
            {
                potentialMoves.Add(1);
            }
            else if ((activeBoard[0] == activeBoard[1] && activeBoard[0] !="_" && legalMoves.Contains(2)) || (activeBoard[5] == activeBoard[8] && activeBoard[5] !="_" && legalMoves.Contains(2)) || (activeBoard[4] == activeBoard[6] && activeBoard[4] !="_" && legalMoves.Contains(2)))
            {
                potentialMoves.Add(2);
            }
            else if ((activeBoard[0] == activeBoard[6] && activeBoard[0] !="_" && legalMoves.Contains(3)) || (activeBoard[4] == activeBoard[5] && activeBoard[4] !="_" && legalMoves.Contains(3)))
            {
                potentialMoves.Add(3);
            }
            else if ((activeBoard[0] == activeBoard[8] && activeBoard[0] !="_" && legalMoves.Contains(4)) || (activeBoard[3] == activeBoard[5] && activeBoard[3] !="_" && legalMoves.Contains(4)) || (activeBoard[1] == activeBoard[7] && activeBoard[1] !="_" && legalMoves.Contains(4)) || (activeBoard[2] == activeBoard[6] && activeBoard[2] !="_" && legalMoves.Contains(4)))
            {
                potentialMoves.Add(4);
            }
            else if ((activeBoard[3] == activeBoard[4] && activeBoard[3] !="_" && legalMoves.Contains(5)) || (activeBoard[2] == activeBoard[8] && activeBoard[2] !="_" && legalMoves.Contains(5)))
            {
                potentialMoves.Add(5);
            }
            else if ((activeBoard[0] == activeBoard[3] && activeBoard[0] !="_" && legalMoves.Contains(6)) || (activeBoard[7] == activeBoard[8] && activeBoard[7] !="_" && legalMoves.Contains(6)) || (activeBoard[2] == activeBoard[4] && activeBoard[2] !="_" && legalMoves.Contains(6)))
            {
                potentialMoves.Add(6);
            }
            else if ((activeBoard[1] == activeBoard[4] && activeBoard[1] !="_" && legalMoves.Contains(7)) || (activeBoard[6] == activeBoard[8] && activeBoard[6] !="_" && legalMoves.Contains(7)))
            {
                potentialMoves.Add(7);
            }
            else if ((activeBoard[0] == activeBoard[4] && activeBoard[0] !="_" && legalMoves.Contains(8)) || (activeBoard[6] == activeBoard[7] && activeBoard[6] !="_" && legalMoves.Contains(8)) || (activeBoard[2] == activeBoard[5] && activeBoard[2] !="_" && legalMoves.Contains(8)))
            {
                potentialMoves.Add(8);
            }
            else
            {
                potentialMoves.Add(-1);
            }

            //      Blockera spelaren eller vinna om ett tillfälle ges
            if (potentialMoves.Count > 1)
            {
                foreach (var move in potentialMoves) 
                {
                    if (activeBoard[move] != player) 
                    { 
                        cpuMove = move;
                    }
                }

                if (cpuMove == -1)
                {
                    cpuMove = potentialMoves[0];
                }
            }
            else if (potentialMoves.Count == 1)
            {
                cpuMove = potentialMoves[0];
            }
            else
            {
                cpuMove = -1;
            }

            return cpuMove;
        }
    }
}
