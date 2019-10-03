using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_1_Asg1_1
{
    public class CheckImageView
    {
        private int length;
        private int bredth;

        public int Plength//its like setting property
        {
            get { return length; }
            //set { length = value; }

            set
            {
                if(value>0)
                {
                    length = value;

                }
            }
            
        }

        public int Pbredth//its like setting property
        {
            get { return bredth; }
            //set { bredth = value; }
            set
            {
                if (value > 0)
                {
                    bredth = value;

                }
                else
                {
                    bredth = 0;//if not put this else condition then also value take is 0
                }
            }
           
        }


        public void CheckView(int length, int bredth)
        {

            if(length > 1.5*bredth && length>0)
            {
                Console.WriteLine("the image is a portrait");
            
            }
            else if(bredth > 1.5*length && bredth>0)
            {
                Console.WriteLine("the image is a landscape");
            }
            else
            {
                Console.WriteLine("cant say if its landscape or portrait");
            }

        }


    }
}
