using System;

namespace Karolis_Stack_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Title");
            var title = Console.ReadLine();

            Console.WriteLine("Input Description");
            var description = Console.ReadLine();

            var post = new Post(title, description);


            Console.WriteLine("Input Upvotes");
            var up = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < up; i++)
            {
                post.UpVote();

            }

            Console.WriteLine("Input Downvotes");
            var down = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < down; i++)
            {
                post.DownVote();
            }

            Console.WriteLine("Title\n" + post.Title);
            Console.WriteLine("Description\n" + post.Description);
            Console.WriteLine("Total votes:\n" + post.VoteNumber);
        }
    }

    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        private int _voteNumber { get; set; }


        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.DateCreated = DateTime.Now;
        }

        public void UpVote() => _voteNumber += 1;
        public void DownVote() => _voteNumber -= 1;


        public int VoteNumber
        {
            get
            {
                return _voteNumber;
            }
        }

    }


}
