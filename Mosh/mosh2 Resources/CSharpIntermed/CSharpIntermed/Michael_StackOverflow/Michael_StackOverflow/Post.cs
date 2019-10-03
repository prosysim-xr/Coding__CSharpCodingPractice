using System;
using System.Collections.Generic;
using System.Text;

namespace Michael_StackOverflow
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _createDate;
        private int _voteTotal;

        public int VoteTotal
        {
            get { return _voteTotal; }
        }

        public void NewPost(string postTitle, string postDesc)
        {
            _title = postTitle;
            _description = postDesc;
            _createDate = DateTime.Now;
            _voteTotal = 0;

        }

        public Tuple<string, string, DateTime> About()
        {
            string title = _title;
            string description = _description;
            DateTime createDate = _createDate;
            return new Tuple<string, string, DateTime>(title, description, createDate);
        }

        public int VotePost(string input)
        {
            if (input == "1")
                _voteTotal++;
            else if (input == "2")
                _voteTotal--;
            return _voteTotal;
        }


    }
}
