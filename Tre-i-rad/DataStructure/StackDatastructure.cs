using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad.DataStructure
{
    public class StackDatastructure : BaseDatastructure
    //                                     2ndra datastrukturen. Stack. Används för att lagra datan
    {
        private Stack<string[]> history;

        public StackDatastructure()
        {
            history = new Stack<string[]>();
        }

        public override bool Add(string[] board)
        {
            try
            {
                history.Push(board);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string[] GetLast()
        {
            return history.Peek();
        }

        public override string[] GetAtIndex(int index)
        {
            if (index == history.Count - 1)
            {
                return history.Peek();
            }
            else
            {
                for (int i = 0; i < history.Count - index; i++) 
                {
                    history.Pop();
                }

                return history.Peek();
            }
        }

        public override bool RemoveLast()
        {
            try
            {
                history.Pop();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void RemoveAll()
        {
            int count = history.Count;

            for (int i = 0; i < count; i++)
            {
                history.Pop();
            }
        }
    }
}
