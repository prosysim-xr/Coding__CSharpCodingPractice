using System;

namespace Marco_StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = "About elephants";
            var description = "Can elephants fly?";
            var post = new Post(title, description, DateTime.Now);

            Console.WriteLine("Your post was created and can be upvoted");
            post.VoteCount();
            Console.WriteLine($"The vote count for this post is {post.GetVoteCount()}");
        }
    }
}

