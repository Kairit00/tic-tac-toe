using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad.DataStructure
{
    public abstract class BaseDatastructure
        //                               Gemensamma funktioner till de båda datastrukturerna
    {
        public abstract bool Add(string[] board);
        public abstract string[] GetLast();
        public abstract string[] GetAtIndex(int index);
        public abstract bool RemoveLast();
        public abstract void RemoveAll();
    }
}
