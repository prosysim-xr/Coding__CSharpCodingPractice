using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg1_Class_Propertes_exer_StopWatch_Blog
{
    class BlogWriter
    {
        public DateTime P_createdOn { get; set; }
        public string P_title { get; set; }
        public string P_description { get; set; }

        public void Write()
        {
            P_createdOn = DateTime.Now;
            Console.Write("please enter the title: ");
            P_title = Console.ReadLine();
            Console.Write("please enter the description: ");
            P_description = Console.ReadLine();
        }
    }
}
