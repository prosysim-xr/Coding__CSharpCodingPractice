using System;
using System.Collections;
using System.Collections.Generic;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }

    }
    
    public class Stack
    {

        private readonly List<object> _list = new List<object>();

//        private readonly List<object> _list;


        public bool IsEmpty

        {
            get
            {
                return _list.Count == 0;
            }
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }

        public Stack()
        {
            _list = new List<object>();
        }


        public void Push(object item)
        {
            if (item == null)

                throw new InvalidOperationException("item cant be null!");

            _list.Add(item);
//            _list.Add(item);

        }

        public object Pop()
        {
            if (IsEmpty)

                throw new InvalidOperationException("Stack is empty!");

            var item = _list[Count];

            _list.RemoveAt(Count);

            return item;

        }

        public void Clear()
        {
            _list.Clear();
        }

    }

}