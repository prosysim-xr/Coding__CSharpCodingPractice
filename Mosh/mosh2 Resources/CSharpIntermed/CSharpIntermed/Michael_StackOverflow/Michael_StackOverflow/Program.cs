using System;

namespace Michael_StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name your post!");
            var titleInput = Console.ReadLine();
            Console.WriteLine("Enter your post below! Please follow community guidelines when posting!");
            var descriptInput = Console.ReadLine();
            var post1 = new Post();
            post1.NewPost(titleInput, descriptInput);
            while (true)
            {
                Console.WriteLine("Amazing work!");
                Console.WriteLine("Press '0' to learn about this post.");
                Console.WriteLine("Press '1' to upvote this awesome post.");
                Console.WriteLine("Press '2' to downvote this stupid post.");
                var userAct = Console.ReadLine();
                if (userAct == "0")
                {
                    var aboutPost = post1.About();
                    var thisPostTitle = aboutPost.Item1;
                    var thisPostDesc = aboutPost.Item2;
                    var thisPostDate = aboutPost.Item3;
                    Console.WriteLine("Title: " + thisPostTitle);
                    Console.WriteLine("Description: " + thisPostDesc);
                    Console.WriteLine("Created on: " + thisPostDate);
                }
                else if (userAct == "1" || userAct == "2")
                {
                    post1.VotePost(userAct);
                }
                Console.WriteLine("Current Post Rating: {0}", post1.VoteTotal);


            }

        }
    }
}
