using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            while(exit != true)
            {
                int option;
                Console.WriteLine(
                    "----------------------------------------------\n" +
                    "Enter an option\n"+
                    "Enter 1 for friends that liked your comment \n" +
                    "Enter 2 for q1forAsg : friends liked your comment\n" +
                    "Enter 3 for  Reverse Name\n" +
                    "Enter 4 for  Reverse Num\n" +
                    "Enter 5 for  enter unrepeated number \n" +
                    "Enter 6 for  enter numbers to unique number display\n" +
                    "Enter 7 for  supply comma seperated num(demo of sort func plus string array)\n" +
                    "Enter 8 for  \n" +
                    "----------------------------------------------\n");
                
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you chose: " + option);
                Console.WriteLine();
                Console.WriteLine(
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                switch (option)
                {
                    case 1:
                        {
                            var q1 = new _q1FriendsDisplay();
                            q1.FreindDisplay();
                            break;
                        }
                    case 2:
                        {
                            var objQ2 = new Q1friendsComment();
                            objQ2.FrindsDisplay();
                            break;
                        }
                    case 3:
                        {
                            var objReverse = new ReverseName();
                            objReverse.Reverse();
                            break;
                        }
                    case 4:
                        {
                            var objReverse1 = new ReverseNum();
                            objReverse1.Reverse1();
                            break;
                        }
                    case 5:
                        {
                            var objunrepeat = new UnrepeatedNumberList();
                            objunrepeat.Rept();
                            break;
                        }
                    case 6:
                        {
                            var objUnique = new UniqueResultDisplay();
                            objUnique.Unique();
                            break;
                        }
                    case 7:
                        {
                            var objSupply = new SupplyCommaSeperatedNum();
                            objSupply.ListNum();
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                }

            }
        }
    }
}
