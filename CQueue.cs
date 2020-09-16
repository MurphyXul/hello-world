using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLib
{
    public class CQueue
    {
        private List<int> _queue;

        public CQueue()
        {
            if (_queue == null) 
            {
                _queue = new List<int>();
            }
        }

        public void AppendTail(int value)
        {
            _queue.Add(value);
        }

        public int DeleteHead()
        {
            if (_queue.Count > 0) 
            {
                int retVal = _queue[0];
                _queue.RemoveAt(0);
                return retVal;
            }
            return -1;
        }
    }
}
