using System;
using System.Collections.Generic;

namespace Norbert_Stack
{
    public class Stack
    {
        private readonly List<object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException
                    ("You cannot Push 'null' to the Stack.");

            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException
                    ("There is nothing in the Stack to Pop.");

            var obj = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return obj;
        }

        public void Clear()
        {
            if (_stack.Count == 0)
                Console.WriteLine("There is nothing to Clear. Stack is Empty.");
            else
                _stack.Clear();
        }
    }

    class Program
    {
        public static void Main()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push("Two");
            stack.Push(3.14);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();
        }
    }
}
