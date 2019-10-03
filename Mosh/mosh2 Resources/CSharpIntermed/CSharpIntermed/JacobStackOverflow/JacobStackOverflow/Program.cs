using System;

namespace JacobStackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackPost = new Post();
            stackPost.MakePost("How do I convert a string to a int", "I need help converting a string to an int");
            Console.WriteLine(stackPost.DisplayPost());
            stackPost.Vote();
        }
    }
}
