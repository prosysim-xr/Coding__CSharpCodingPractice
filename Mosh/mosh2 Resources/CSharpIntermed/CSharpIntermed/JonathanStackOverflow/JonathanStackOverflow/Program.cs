using System;
using System.Collections.Generic;

namespace JonathanStackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Post aPost = new Post("Best C# Hat?", "When I am programming in C# what sort of hat is best to wear?");
            Conversation aConversation = new Conversation(aPost);
            int whichPost = aConversation.PostList.Count - 1; // -1 to not go out of bounds on array
            ConversationPageView page = new ConversationPageView(aConversation, whichPost);

            // start the exercise with two 'other' upvotes
            System.Threading.Thread.Sleep(1400);
            page.Vote(true, aConversation, whichPost);

            System.Threading.Thread.Sleep(1400);
            page.Vote(true, aConversation, whichPost);

            // start the vote interface for the user
            VotingInterface StartVoting = new VotingInterface();
            StartVoting.Voting(page, aConversation, whichPost);

            // all done, close it up and turn out the lights
            Environment.Exit(0);
        }

        // the keyboard interface to take input from the user and toggle the PageViewModel
        public class VotingInterface
        {
            private bool _completed;
            private ConsoleKeyInfo _key;

            public VotingInterface()
            {
            }

            public void Voting(ConversationPageView page, Conversation conversation, int postNum)
            {
                bool userVote;
                Console.WriteLine();
                Console.WriteLine("Press '+' Key to upvote, Press '-' to downvote, Q to quit");

                while (_completed == false)
                {
                    _key = Console.ReadKey(true);

                    switch (_key.Key)
                    {
                        // two cases for upvote: the plus key next to backspace and plus key on numpad
                        case ConsoleKey.Add:
                        case ConsoleKey.OemPlus:
                            userVote = true;
                            page.Vote(userVote, conversation, postNum);
                            break;

                        // two cases for downvote: the minus key near backspace and minus key on numpad
                        case ConsoleKey.Subtract:
                        case ConsoleKey.OemMinus:
                            userVote = false;
                            page.Vote(userVote, conversation, postNum);
                            break;

                        case ConsoleKey.Q:
                            Console.Clear();
                            Console.WriteLine("Closing Console");
                            System.Threading.Thread.Sleep(2000);
                            _completed = true;
                            break;
                    }
                }
            }
        }

        // extra work I tacked on to the exercise, this is a basic PageViewModel that also updates the page
        public class ConversationPageView
        {
            public ConversationPageView(Conversation conversation, int postNum)
            {
                string pad = " ";
                Post cp = conversation.PostList[postNum];

                // 'later' wrap in a for each to see all replies, for now use postNum to write a specific post
                Console.WriteLine($"{cp.VoteCount}   {cp.Title}");
                Console.WriteLine();
                Console.WriteLine(pad.PadLeft(4) + cp.Description);
                Console.WriteLine(pad.PadLeft(30) + cp.PostDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }

            public void Vote(bool upvote, Conversation conversation, int postNum)
            {
                conversation.PostList[postNum].Vote(upvote);
                UpdateVoteCount(conversation, postNum);
            }

            public void UpdateVoteCount(Conversation conversation, int postNum)
            {
                // 'later' add math to offset cursor to beginning of specific post where VoteCount is displayed
                int cursorReturnLeft = Console.CursorLeft;
                int cursorReturnTop = Console.CursorTop;

                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.Write($"{conversation.PostList[postNum].VoteCount}");
                Console.SetCursorPosition(cursorReturnLeft, cursorReturnTop);
                Console.CursorVisible = true;
            }
        }

        // extra work - A collection of posts for a page, we are only using the starting original post for this example
        public class Conversation
        {
            public List<Post> PostList { get; set; }

            public Conversation(Post start)
            {
                PostList = new List<Post> { start };
            }

            public void Delete()
            {
                // implement 'later'
            }

            public void Flag()
            {
                // To implement 'later'
            }

            public void ReSortReplies()
            {
                // to be implemented based on vote totals
            }
        }

        // the 'Model' class for the StackOverflow exercise - data and methods to manipulate data go here
        public class Post
        {
            public int VoteCount { get; private set; }
            public string Title { get; }
            public string Description { get; }
            public DateTime PostDateTime { get; }

            // initialize value in constructor
            public Post(string title, string description)
            {
                Title = title;
                Description = description;
                PostDateTime = DateTime.Now;
            }

            // method to change _vote backing value
            public void Vote(bool vote)
            {
                if (vote)
                    VoteCount++;
                else
                    VoteCount--;
            }

            // in real world would add edit and delete methods for fields
        }
    }
}
