using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg2_Loops_Factorials
{
    class _4GuessGame
    {
        public void GuessIt()
        {
            int num;
            var random = new Random();
            int ranNum = random.Next(0, 10);
            Console.WriteLine("Please enter a number\n");
            Console.WriteLine($"Dont look here but the number might be {ranNum}");

            for (int i = 0; i < ranNum; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == ranNum)

                {
                    Console.WriteLine("you won\n");
                    break;
                }
                else
                {

                    if (i == 3)
                    {
                        Console.WriteLine("You lost");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("try Again");
                    }
                }
            }

            //public void Exercise4()
            //{
            //    var number = new Random().Next(1, 10);

            //    Console.WriteLine("Secret is " + number);
            //    for (var i = 0; i < 4; i++)
            //    {
            //        Console.Write("Guess the secret number: ");
            //        var guess = Convert.ToInt32(Console.ReadLine());

            //        if (guess == number)
            //        {
            //            Console.WriteLine("You won!");
            //            return;
            //        }
            //    }

            //    Console.WriteLine("You lost!");
            //}



        }


    }
}
