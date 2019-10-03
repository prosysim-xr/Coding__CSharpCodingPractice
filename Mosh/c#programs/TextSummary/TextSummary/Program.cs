using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            //OVERRIDE EXAMPLE IT CAN BE --later see this and complete
            var sentence = "Did The Quick Brown Fox Jumped Over Suman's Lazy Dog? Yes, " +
                "It Did: It Did In The Forest Near The Bank Of Holy River \"GANGA\"; the cat did the same";
            Console.WriteLine("Plese enter total character in the summary\n");
            var summaryTextLength = Convert.ToInt32(Console.ReadLine());

            Text.TextSum(sentence, summaryTextLength);
            Console.WriteLine();
            var objTextSum = new Text();
            objTextSum.TextSum2(sentence, summaryTextLength);
            Console.ReadKey();
        }
    }
}
