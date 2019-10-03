using System;
using System.Collections.Generic;
using System.Text;

namespace Tom_Stack
{
    class Stack
    {
        private readonly System.Collections.Stack _stack;
        public Stack()
        {            _stack = new System.Collections.Stack();
        }
        public void Push(object obj)
        {
            try
            {
                if (obj.Equals(null))
                {
                    throw new InvalidOperationException("Objects with a value of null cannot be stored in the stack!");
                }
                else
                {
                    _stack.Push(obj);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public object Pop()
        {
            try
            {
                if (_stack.Count == 0)
                {
                    throw new InvalidOperationException("Objects cannot be removed from an empty stack!");
                }
                else
                {
                    return _stack.Pop();
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Clear()
        {
            try
            {
                if (_stack.Count == 0)
                {
                    throw new InvalidOperationException("Objects cannot be cleared from an empty stack!");
                }
                else
                {
                    var count = _stack.Count;
                    _stack.Clear();
                    return $"{count} items cleared from stack";
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
