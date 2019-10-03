using System;

namespace HunterStackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Grab info from user
            var post = new Post();
            Console.Write("Title for your post: ");
            post.Title = Console.ReadLine();
            Console.Write("Description for your post: ");
            post.Description = Console.ReadLine();

            System.Console.WriteLine();
            System.Console.WriteLine("----Stack Overflow Post----");
            System.Console.WriteLine("Title: " + post.Title);
            System.Console.WriteLine("Description: " + post.Description);
            System.Console.WriteLine("Posted time: " + post.DatePosted);
            System.Console.WriteLine();

            while (true)
            {
                System.Console.Write("Type 'yes' to up-vote this post. Type 'no' to down-vote it. (Type 'quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "yes")
                    post.UpVote();
                else if (input.ToLower() == "no")
                    post.DownVote();
                else if (input.ToLower() == "quit")
                    break;
                else
                    System.Console.WriteLine("Please type a valid answer.");
            }

            System.Console.WriteLine("Total up-votes: {0}", post.UpVotes);
            System.Console.WriteLine("Total down-votes: {0}", post.DownVotes);

//            Console.WriteLine("Press any key to exit.");
//            Console.ReadKey();
        }
    }
}
