using System;
using System.Collections.Generic;
using System.Text;

namespace TimStackOverFlow
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _dateCreated;
        private int _voteValue;

        public Post()
        {

        }

        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
            _dateCreated = DateTime.Now;
        }

        public void CreatePost(string postTitle, string postDescription)
        {
            _title = postTitle;
            _description = postDescription;
            _dateCreated = DateTime.Now;
        }

        public void DisplayPost()
        {
            Console.WriteLine($"Date Posted: {_dateCreated:f}");
            Console.WriteLine($"Post Title: {_title}");
            Console.WriteLine($"Post Description: {_description}");
            Console.WriteLine($"Up Votes: {_voteValue}");
        }

        public void UpVote()
        {
            _voteValue++;
        }

        public void DownVote()
        {
            _voteValue--;
        }
    }
}
