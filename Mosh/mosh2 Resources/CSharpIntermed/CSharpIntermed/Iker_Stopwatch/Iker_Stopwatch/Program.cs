using System;

namespace Iker_Stopwatch
{
    public class Stopwatch
    {
        private DateTime start;
        private DateTime stop;
        private TimeSpan resultado;


        public DateTime Start()
        {
            return start = DateTime.Now;
        }
        public DateTime Stop()
        {
            return stop = DateTime.Now;
        }

        public TimeSpan Resultado()
        {
            resultado = stop - start;
            return resultado;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var Stopwatch = new Stopwatch();
            string empzr;
            string parar;
            string exit;

            do
            {
                Console.WriteLine("Welcome to the Stopwatch");
                Console.WriteLine("write 's' to start the stopwatch");
                empzr = Console.ReadLine();


                if (empzr == "s")
                {
                    Stopwatch.Start();
                }
                Console.WriteLine("write 'p' stop the stopwatch");
                parar = Console.ReadLine();

                if (parar == "p")
                {
                    Stopwatch.Stop();
                }
                if (empzr == "s" && parar == "p")
                {
                    Console.WriteLine("  Time: {0}", Stopwatch.Resultado());
                }

                Console.WriteLine("write 'e' to exit of the stopwatch");
                exit = Console.ReadLine();


            } while (exit != "e");
        }
    }
}
