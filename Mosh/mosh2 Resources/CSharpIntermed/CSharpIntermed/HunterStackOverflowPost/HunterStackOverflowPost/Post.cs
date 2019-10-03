using System;
using System.Collections.Generic;
using System.Text;

namespace HunterStackOverflowPost
{
    public class Post
    {
        private string _title;
        private string _description;
        private int _upVotes;
        private int _downVotes;

        public int UpVotes { get { return _upVotes; } }
        public int DownVotes { get { return _downVotes; } }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime DatePosted
        {
            get { return DateTime.Now; }
        }

        public void UpVote()
        {
            _upVotes += 1;
        }
        public void DownVote()
        {
            _downVotes += 1;
        }
    }
}
