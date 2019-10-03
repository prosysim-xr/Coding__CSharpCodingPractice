using System;
using System.Collections.Generic;

namespace StackOriginal
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();

            int ini = 1;
            int max = 5;

            for (int i = ini; i <= max; i++)
            {
                _stack.Push(i);
            }

            for (int i = ini; i <= max; i++)
            {
                Console.WriteLine(_stack.Pop());
                
            }

            Console.ReadLine();
        }
    }

    public class Stack
    {

        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj==null)
            {
                throw new InvalidOperationException("You can't add a null object to the stack!");
            }

            _list.Add(obj);

            #region Deleted in revised version of Stack.

            int elements = _list.Count;

            if (elements > 1)
            {
                for (int i = elements-1; i > 0; i--)
                {
                    _list[i] = _list[i-1];
                }

                _list[0] = obj;
            }

            #endregion
        }

        public object Pop()
        {
            if (_list.Count==0)
            {
                throw new InvalidOperationException("There are no elements in the stack yet.");
            }

            object ToReturn = _list[0];

            #region Deleted in Revised version of Stack.

            int elements = _list.Count;
            for (int i = 0; i < elements - 1; i++)
            {
                _list[i] = (int) _list[i + 1];
            }

            #endregion

            _list.Remove(elements - 1);

            return (ToReturn);
        }

    }
}
