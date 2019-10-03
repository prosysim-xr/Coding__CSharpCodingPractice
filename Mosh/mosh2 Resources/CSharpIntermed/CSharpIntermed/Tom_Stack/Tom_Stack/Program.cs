using System;

namespace Tom_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            Console.WriteLine(stack.Clear());

            stack.Push(DateTime.Now);
            stack.Push("Stack Example Exercise");
            stack.Push(1);
            stack.Push(1.23456789);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Pop());

            stack.Push(1);
            Console.WriteLine(stack.Clear());
        }
    }
}
