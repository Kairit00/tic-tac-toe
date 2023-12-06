using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_i_rad.DataStructure
{
    public class LinkedListDatastructure : BaseDatastructure
                //                          1 av våra datastrukturer, den samlar info om spelplanen så att vi kan använda den. LinkList
    {
        private LinkedList<string[]> history;

        public LinkedListDatastructure()
        {
            history = new LinkedList<string[]>();
        }

        public override bool Add(string[] board)
        {
            try
            {
                history.AddLast(board);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string[] GetLast()
        {
            int count = history.Count;
            return history.ElementAt(count - 1);
        }

        public override string[] GetAtIndex(int index)
        {
            return history.ElementAt(index);
        }

        public override bool RemoveLast()
        {
            try
            {
                history.RemoveLast();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void RemoveAll()
        {
            history.Clear();
        }
    }
}
