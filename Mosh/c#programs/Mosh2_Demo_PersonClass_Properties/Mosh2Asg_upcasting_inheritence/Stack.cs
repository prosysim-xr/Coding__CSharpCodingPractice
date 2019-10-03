using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg_upcasting_inheritence
{
    public class Stack
    {
        private ArrayList stackList = new ArrayList();
        public void Push(Object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            else
                stackList.Add(obj);
        }

        public Object Pop()
        {
            if (stackList.Count <= 0)
            {
                throw new InvalidOperationException("the list is empty");
            }
            else 
            {
                var index = stackList.Count - 1;
                var toReturn= stackList[index];
                //stackList.Remove(stackList[stackList.Count - 1]);
                stackList.RemoveAt(index);
                return toReturn;
            }
        }
        public void Clear()
        {
            if (stackList.Count == 0)
            {
                throw new Exception("stackList is empty");
            }
            foreach(var value in stackList)
            {
                stackList.Remove(value);
            }
        }
    }
}
