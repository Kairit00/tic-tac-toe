using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tre_i_rad.DataStructure;

namespace Tre_i_rad
{
    public class Board
        //                                         Spelplanen
    {
        //                          Spara ner spelbrädet till Stack - datastrukturen
        private static StackDatastructure _stackDatastructure = new();
        private static string[] activeBoard = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };

        public Board() 
        {
            Save();
        }

        public string[] ActiveBoard
        {
            get { return activeBoard; }
            set { activeBoard = value; }
        }

        //                                      Undo funktionen
        public static void UndoMove()
        {
            _stackDatastructure.RemoveLast();
            _stackDatastructure.RemoveLast();
            activeBoard = _stackDatastructure.GetLast();
            Game.LegalMoves = CheckLegalMoves();
            foreach (var move in Game.LegalMoves) 
            { 
                Console.Write(move);
            }
        }

        //                          Lägger till splelarens val på brädet, updaterar hur brädet ser ut och vilka val som är giltiga / ogiltiga att spela

        public static void Add(int position, string player)
        {
            activeBoard[position] = player;
            Save();
        }

        private static void Save()
        {
            string[] temp = { "", "", "", "", "", "", "", "", "" };

            for (int i = 0; i < activeBoard.Length; i++)
            {
                temp[i] = activeBoard[i];
            }

            _stackDatastructure.Add(temp);
        }

        public static List<int> CheckLegalMoves()
        {
            List<int> legalMoves = new();
            for (int i = 0; i < activeBoard.Length; i++) 
            { 
                if (activeBoard[i] == "_")
                {
                    legalMoves.Add(i);
                }
            }

            return legalMoves;
        }

        public static void Clear()
        {
            string[] newBoard = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };
            activeBoard = newBoard;
        }

        public static void Reset() 
        { 
            Clear();
            Game.LegalMoves = CheckLegalMoves();
        }


        //                                          Spelplanen och vilken siffra som är vart
        public static void Display()
        {
            Console.WriteLine("\n|" + activeBoard[0] + "|" + activeBoard[1] + "|" + activeBoard[2] + "|");
            Console.WriteLine("|" + activeBoard[3] + "|" + activeBoard[4] + "|" + activeBoard[5] + "|");
            Console.WriteLine("|" + activeBoard[6] + "|" + activeBoard[7] + "|" + activeBoard[8] + "|");
        }
    }
}
