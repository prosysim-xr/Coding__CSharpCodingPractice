using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg_WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"the number of words in the  \"{Words()}\" is " + WordCount());

            var objMaxWord = new Program();
            var content1 = objMaxWord.MaxWord();
            foreach(var value in content1)
            {
                Console.WriteLine(value);
            }

            //for biggest word
            var big = BiggestWord();
            Console.WriteLine("sorted biggest words are: ");
            foreach (var value in BiggestWord2(big))
            {
                Console.Write(value);
            }

            Console.WriteLine("biggest word is "+ big[big.Length-1]);

            Console.ReadKey();
        }
        public static int WordCount()
        {
            var path = @"C:\Users\suman\Desktop\cSharpText.txt";
            var contents = File.ReadAllText(path);
            var contentsArr = contents.Split(' ');
            return contentsArr.Length;
        }

        public static string Words()
        {
            var path = @"C:\Users\suman\Desktop\cSharpText.txt";
            var contents = File.ReadAllText(path);
            return contents;
        }

        public string[] MaxWord()
        {
            var path = @"C:\Users\suman\Desktop\cSharpText - Copy.txt";
            var contents = File.ReadAllLines(path);
            //var contentsList = new List<string> { };
            //foreach(var value in contents);
            return contents;
        }

        public static string[] BiggestWord()
        {
            var path = @"C:\Users\suman\Desktop\cSharpText.txt";
            var contents = File.ReadAllText(path);
            //var contentsList = new List<string> { };
            //foreach(var value in contents);
            return contents.Trim().Split(' ');
        }
        public static string[] BiggestWord2(string[] big)
        {
            for(var i = 0; i< big.Length-1; i++)
            {
                for(var j =i+1; j<big.Length; j++)
                {
                    if (big[i].Length > big[j].Length)
                    {
                        var temp = big[i];
                        big[i] = big[j];
                        big[j] = temp;
                    }
                }
            }

            return big;
        }

    }
}
