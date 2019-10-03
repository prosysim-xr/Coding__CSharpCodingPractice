using System;
using System.Collections.Generic;
using System.Text;

namespace Marco_StackOverFlow
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private int _voteCount;

        public Post(string title, string description, DateTime timeStamp)
        {
            _title = title;
            _description = description;
            _date = timeStamp;
            _voteCount = 0;
        }

        public void VoteCount()
        {
            while (true)
            {
                Console.WriteLine("Press 'H/h' to dislike the post, 'L/l' to like it or 'Q/q' to close the post for voting.");

                var myKey = Console.ReadLine();

                if (myKey.ToUpper() == "L")
                {
                    _voteCount += 1;
                    Console.WriteLine($"+1");
                    continue;
                }
                else if (myKey.ToUpper() == "H")
                {
                    _voteCount -= 1;
                    Console.WriteLine($"-1");
                    continue;
                }
                else if (myKey.ToUpper()=="Q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input key");
                    continue;
                }
            }
        }

        public int GetVoteCount()
        {
            return _voteCount;
        }

    }
}
