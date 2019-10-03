using System;

namespace StackOverflow
{
    class Program
    {
        /// <summary>
        /// Entry point of application
        /// From Dylan on Udemy
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creating an instance of the Post class
            var post = new Post
            {
                Title = "C# Course",
                Description = "Intermediate course by Mosh",
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.DisplayVotes();
        }
    }

    public class Post
    {
        // Fields
        public string Title { get; set; }
        public string Description { get; set; }
        private readonly DateTime _dateOfCreation = DateTime.Now;
        private int _votes;
        private int _upVotes;
        private int _downVotes;

        /// <summary>
        /// Public method to display the full post and number of votes
        /// </summary>
        public void DisplayVotes()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Date and time Created: " + _dateOfCreation);
            Console.WriteLine("Number of votes total: " + _votes + "\n");
            Console.WriteLine("-------------------------------------" + "\n");
            Console.WriteLine("Votes Count: ");
            Console.WriteLine("Number of UpVotes: " + _upVotes);
            Console.WriteLine("Number of DownVotes: " + _downVotes);
        }

        /// <summary>
        /// Public method that increases the number of upvotes
        /// I suggested some Console.Writeline in each vote method to give visual to use when an up or down vote has occurred.
        /// </summary>
        /// <returns>Increases total votes by 1</returns>
        public int UpVote()
        {
            _upVotes++;
            Console.WriteLine("UpVote of 1 has occurred.");
            return _votes++;
        }

        /// <summary>
        /// Public method that increases the number of downvotes
        /// </summary>
        /// <returns>Decreases total votes by 1</returns>
        public int DownVote()
        {
            _downVotes++;
            Console.WriteLine("DownVote of 1 has occurred.");
            return _votes--;
        }
    }
}
