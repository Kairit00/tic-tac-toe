using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad
{
    internal interface IPlayer
        //                      Både CPU:n och spelarens gemensamma MakeMove funktion
    {
        void MakeMove(string player, string[] activeBoard, List<int> legalMoves);
    }
}
