using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK
{
    class Stack
    {
        private ArrayList _stack;
        private object _poppedElement;
        private int _indexOfStack;

        public Stack()
        {
            _stack = new ArrayList();
            _indexOfStack = 0;
            this._poppedElement = null;
        }

        public void Push(object obj)
        {
            if (obj is null)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count < 1)
            {
                return "Stack is empty";
            }

            _poppedElement = _stack[_stack.Count - 1];
            _indexOfStack = _stack.Count;
            _stack.RemoveAt(_indexOfStack - 1);

            return _poppedElement;
        }

        public void Clear()
        {
            _stack.Clear();
        }

        private void trash()
        {
            this._poppedElement = null;
            this._indexOfStack = 0;
            this._stack.Clear();
        }
    }
}