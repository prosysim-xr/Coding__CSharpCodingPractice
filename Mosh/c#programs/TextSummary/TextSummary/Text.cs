using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummary
{
    class Text
    {
        public static void TextSum(string sentence, int summaryTextLength)
        {
            Console.WriteLine(sentence.Substring(0, summaryTextLength));
        }

        public void TextSum2(string sentence, int summaryTextLength)
        {
            var str = sentence;
            var strArr = sentence.Split(' ');

            var count = 0;
            var j = 0;

            while (true)
            {
                if (count <= summaryTextLength)
                {
                    count += strArr[j].Length + 1;//strArr[j].Length + 1 because space also is added
                    j++;
                }
                else
                {
                    break;
                }
            }
            for (var i = 0; i < j - 1; i++)//j-1 because we want count strictly less than 60, if till j then it could just above 60
            {
                Console.Write($"{strArr[i]}" + " ");
            }
            Console.WriteLine(".....");
        }
    }
    //// alternatively
    //var totalCharacter = 0;
    //var strList = new List<string>();
    //foreach(var value in strList)
    //{
    //    strList.Add(value);
    //    totalCharacters+=value.Length
    //    if(totalCharacter>summarTextLength)
    //    {
    //        break;
    //    }
    //}
    //Console.WriteLine("summary is "+Sring.Join(strList)+" ....");
}
