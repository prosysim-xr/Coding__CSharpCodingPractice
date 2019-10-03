using System;

namespace SotirisStackOverflow
{
    class Program

    {

        static void Main(string[] args)

        {

            bool quitLoop = false;

            Post post = new Post();

            post.Date = DateTime.Now;

            post.Title = "C# intermediate classes\n";

            Console.WriteLine("Post Tile: " + post.Title + "\n");

            post.Description = "I have a Visual Studio 2017 Solution that has some header-only dependencies that are multi platform and use CMake...............\n";

            Console.WriteLine("Post Description: " + post.Description + "\n");



            while (!quitLoop)       //Loop variable is never chan

            {

                Console.WriteLine("Press 1 to Vote up the post,2 to Vote down or 3 to preview the Votes of the post:");

                var input = Convert.ToInt32(Console.ReadLine());

                try

                {

                    if (input == 1)

                    {

                        post.VoteUp = 1;

                    }

                    if (input == 2)

                    {

                        post.VoteDown = 1;

                    }

                    if (input == 3)

                    {

                        post.Votes();

                    }

                    else

                    {

                        Console.WriteLine("Invalid input,please try again\n");

                        continue;

                    }

                }

                catch (InvalidCastException)

                {



                }





            }



        }

    }

}

class Post

{

    public int sumVotes = 0;

    private int _voteUp = 0;

    private int _voteDown = 0;

    public DateTime Date { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int VoteUp

    {

        get

        {

            return _voteUp;

        }

        set

        {

            _voteUp = VoteUp + value;



        }

    }

    public int VoteDown

    {

        get

        {

            return _voteDown;

        }

        set

        {

            _voteDown = VoteDown - value;



        }

    }

    public void Votes()

    {

        Console.WriteLine("Current Post's Votes are:" + (_voteUp + _voteDown));

    }

}





