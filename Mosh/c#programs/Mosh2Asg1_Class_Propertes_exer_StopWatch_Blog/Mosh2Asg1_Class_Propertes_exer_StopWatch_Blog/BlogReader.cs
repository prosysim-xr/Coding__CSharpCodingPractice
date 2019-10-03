using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg1_Class_Propertes_exer_StopWatch_Blog
{
    class BlogReader
    {
        public int P_likes { get; set; }
        public int P_dislikes { get; set; }

        public BlogReader()
        {
            P_likes = 0;
            P_dislikes = 0;
        }


        public void Show(BlogWriter objW, BlogReader objR)
        {
            ShowTitle(objW);
            ShowCreatedOn(objW);
            ShowDescription(objW);
            ShowLikes(objR);
            ShowDislikes(objR);
        }


        public int GiveLikes()
        {
            return ++P_likes;
        }
        public int GiveDislikes()
        {
            return ++P_dislikes;
        }


        public void ShowTitle(BlogWriter objW)
        {
            Console.WriteLine("Title: " + objW.P_title);
        }
        public void ShowCreatedOn(BlogWriter objW)
        {
            Console.WriteLine("CreatedOn: " + objW.P_createdOn);
        }
        public void ShowDescription(BlogWriter objW)
        {
            Console.WriteLine("Description: " + objW.P_createdOn);
        }
        public void ShowLikes(BlogReader objR)
        {
            Console.WriteLine("Likes: " + objR.P_likes);
        }
        public void ShowDislikes(BlogReader objR)
        {
            Console.WriteLine("Dislikes: " + objR.P_dislikes);
        }
    }
}
