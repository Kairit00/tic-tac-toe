using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tre_i_rad.DataStructure;

namespace Tre_i_rad
{
    public class Game
                //              Denna klass kollar i princip vem som har vunnit och skriver ut det
    {
        static List<int> legalMoves = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

        public static List<int> LegalMoves
        {
            get { return legalMoves; }
            set { legalMoves = value; }
        }
            //                   Checkwin kollar för om när någon har vunnit, förlorat eller om det är oavgjort. 
        public static bool CheckWin(string player, string[] board)
        {
            string winner = "";

            if (board != null)
            {
                if (board[0] == board[1] && board[1] == board[2] && board[0] != "_")   //    Vågrätt
                {
                    winner = board[0];
                }
                else if (board[3] == board[4] && board[4] == board[5] && board[3] != "_")  //   |
                {
                    winner = board[3];
                }
                else if (board[6] == board[7] && board[7] == board[8] && board[6] != "_")  //   v
                {
                    winner = board[6];
                }
                else if (board[0] == board[3] && board[3] == board[6] && board[0] != "_")  // Lodrätt
                {
                    winner = board[0];
                }
                else if (board[1] == board[4] && board[4] == board[7] && board[1] != "_") //    |
                {
                    winner = board[1];
                }
                else if (board[2] == board[5] && board[5] == board[8] && board[2] != "_") //    V
                {
                    winner = board[2];
                }
                else if (board[0] == board[4] && board[4] == board[8] && board[0] != "_") // Diagonalt
                {
                    winner = board[0];
                }
                else if (board[2] == board[4] && board[4] == board[6] && board[2] != "_")
                {
                    winner = board[2];
                }

                //                                  Utskrift om någon vinner eller förlorar
            }
            if (winner != "")
            {
                if (winner == player)
                {
                    Console.WriteLine("\nYou won!");
                    Melodies.PlayVictoryMelody();
                }
                else
                {
                    Console.WriteLine(" \nYou lost!");
                    Melodies.PlayLosingMelody();
                }

                return true;
            }
            return false;
        }
            //                                                      Oavgjort
        public static bool CheckDraw(string player, string[] board)
        {
            bool fullBoard = true;

            for (int i = 0; i < board.Length; i++) 
            {
                if (board[i] == "_")
                {
                    fullBoard = false;
                }
                
            }

            if (fullBoard && CheckWin(player, board) == false)
            {
                Console.WriteLine("\nIt's a draw!");
                Melodies.PlayitsAdrawMelody();
                return true;
            }
            else return false;

        }
    }
}
