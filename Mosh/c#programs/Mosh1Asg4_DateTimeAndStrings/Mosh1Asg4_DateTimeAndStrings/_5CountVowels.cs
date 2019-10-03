using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg4_DateTimeAndStrings
{
    class _5CountVowels
    {

        public void Exercise5()
        {
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsInt = new int[5];
            var vowelsCount = 0;

            for(var i=0; i<input.Length; i++)
            {
                if (vowels.Contains(vowels[i]))
                {
                    vowelsInt[i]++;
                    vowelsCount++;
                }
            }

            //Display
            Console.WriteLine(vowelsCount);
            for(var i = 0; i<5; i++)
            {
                Console.WriteLine(vowels[i] + " :" + vowelsInt[i] + "\n");
            }
            
        }


        public void VowelCountOnlyTotal()
        {
            Console.WriteLine("Plese enter an English Word\n");
            var input = Console.ReadLine();

            var charArr = input.ToLower().Trim();
            var count = 0;
            for (var i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 'a' || charArr[i] == 'e' || charArr[i] == 'i' ||
                charArr[i] == 'o' || charArr[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("vowel count " + count);
        }



        public void VowelCount()
        {
            Console.WriteLine("Plese enter an English Word\n");
            var input = Console.ReadLine();

            var charArr = input.ToLower().Trim();
            //Console.WriteLine(String.Format("{0}",input));
            //---------------------vs-----------------------
            //Console.WriteLine("{0}",input);
            var aCount = 0;
            var eCount = 0;
            var iCount = 0;
            var oCount = 0;
            var uCount = 0;
            for (var i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 'a')
                {
                    aCount++;
                }
                if (charArr[i] == 'e')
                {
                    eCount++;
                }
                if (charArr[i] == 'i')
                {
                    iCount++;
                }
                if (charArr[i] == 'o')
                {
                    oCount++;
                }
                if (charArr[i] == 'u')
                {
                    uCount++;
                }
            }
            var vowelCount = aCount + eCount + iCount + oCount + uCount;
            Console.WriteLine(vowelCount);
            Console.WriteLine("a: "+ aCount + "\ne: "+ eCount + "\ni: "+iCount + "\no: " + oCount + "\nu: " + uCount);
        }

        public void VowelCount2()
        {
            Console.WriteLine("Plese enter an English Word\n");
            var input = Console.ReadLine();

            var charArr = input.ToLower().Trim();//populted array
            var vowelArr = new char[5] { 'a', 'e','i','o','u'};//initialized arary
            var totalVowels = 0;
            var vowelCountArr = new int[5];
            for(var i = 0; i<charArr.Length; i++)
            {
                for(var j = 0; j<5; j++)
                {
                    if(charArr[i] == vowelArr[j])
                    {
                        vowelCountArr[i]++;
                        totalVowels++;
                    }
                }
            }

            //Display
            Console.WriteLine("total vowels are "+totalVowels);
            for(var i = 0; i<5; i++)
            {
                Console.WriteLine(vowelArr[i]+" :"+vowelCountArr[i]);
            }

        }

       
    }
}
