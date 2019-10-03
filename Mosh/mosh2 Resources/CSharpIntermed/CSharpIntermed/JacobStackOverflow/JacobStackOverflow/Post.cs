using System;
using System.Collections.Generic;
using System.Text;

namespace JacobStackOverflow
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdTime;
        private int _upVotes;
        private int _downVotes;
        private string _post;
        private int _totalVotes;

        public void MakePost(string title, string description)
        {
            _title = title;
            _description = description;
            _createdTime = DateTime.Now;
        }

        public string DisplayPost()
        {
            _totalVotes = _upVotes - _downVotes;
            _post = $"{_title}. Destcription: {_description}. \nCreated on: {_createdTime} UPvotes: {_upVotes} Downvotes: {_downVotes} Totalvotes: {_totalVotes} \nUse up to upvote and down to downvote";
            return _post;
        }

        public void Vote()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "up")
                {
                    _upVotes = _upVotes + 1;
                    Console.Clear();
                    Console.WriteLine(DisplayPost());
                }

                if (input.ToLower() == "down")
                {
                    _downVotes = _downVotes + 1;
                    Console.Clear();
                    Console.WriteLine(DisplayPost());
                }

                if (input.ToLower() == "quit")
                {
                    Console.Clear();
                    Console.WriteLine(DisplayPost());
                    break;
                }

            }

        }

    }

}



