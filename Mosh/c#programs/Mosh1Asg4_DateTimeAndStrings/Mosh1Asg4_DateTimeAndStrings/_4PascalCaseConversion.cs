using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg4_DateTimeAndStrings
{
    class _4PascalCaseConversion
    {
        public string PascalCase(string input)
        {
            var strArr = input.Trim().ToLower().Split(' ');

            //-------------------part1 of the string--------------------------------
            var strPart1 = String.Join(" ",strArr).ToUpper();

            var strPart1Arr = strPart1.Split(' ');

            var strPart1Arr_charArr = new char[strPart1Arr.Length];

            for(var i = 0; i< strPart1Arr.Length; i++)
            {
                strPart1Arr_charArr[i] = strPart1Arr[i][0];
            }

            var strPart1Arr_StringArr = new string[strArr.Length];
            for (var i = 0; i < strPart1Arr.Length; i++)
            {
                strPart1Arr_StringArr[i] = Convert.ToString(strPart1Arr_charArr[i]);
            }


            //-------------------part2 of the string-----------------------------------
            var strPart2Arr_StringArr = new string[strArr.Length];
            for(var i =0; i<strArr.Length; i++)
            {
                strPart2Arr_StringArr[i] = strArr[i].Substring(1);
            }



            //--------------------merging of part1 and part 2
            var strArrFinal = new String[2*strPart1Arr.Length];

            for(var i =0; i< 2 * strArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    strArrFinal[i] = strPart1Arr_StringArr[i / 2];
                }
                else
                {
                    strArrFinal[i] = strPart2Arr_StringArr[(i - 1) / 2];//part2 array name must be here
                }
            }
            
            

            //var strPart1Get = strPart1Arr[0]
            //var strPart2 = String.Join(" ", strPart1, 1, 5);
            //Console.WriteLine(strPart2);

            //var builderArr = new StringBuilder[strArr.Length];
            //for(var i = 0; i<strArr.Length; i++)
            //{
            //    builderArr[0] = new StringBuilder(strArr[0]);
            //}

            ////Array.Copy(strArr, builderArr, strArr.Length);//or could have used for each loop
            ////foreach(var value in strArr)
            ////{
            ////    var str = new StringBuilder(value);
            ////    builderArr[value.IndexOf(value)] = str;
            ////}
            
            var pascal = String.Join("", strArrFinal);
            return pascal;
        }





        public string HungarianCase(string input)
        {
            var strArr = input.Trim().ToLower().Split(' ');

            var builderArr = new StringBuilder[strArr.Length];

            //--------------below is bad way probably---- cons of foreach
            //foreach(var value in strArr)
            //{
            //    builderArr[value.IndexOf(value)] = new StringBuilder(value);
            //}

            for (var i = 0; i < strArr.Length; i++)
            {
                builderArr[i] = new StringBuilder(strArr[i]);
            }

            for (var i = 0; i < strArr.Length; i++)
            {
                if (i == 0)
                {
                    var ch = builderArr[i][0];
                    builderArr[i].Remove(0, 1);
                    builderArr[i].Insert(0, new string('_', 1));
                    builderArr[i].Insert(1, new string(ch, 1));
                }
                if (i > 0)
                {
                    ///var c1 = Convert.ToString(builderArr[i][0]);
                    ///var c2 = c1.ToUpper();
                    ///var ch = Convert.ToChar(c2);
                    
                    //var ch = Convert.ToChar(Convert.ToString(builderArr[i][0]).ToUpper());
                    var ch2 = Char.ToUpper(builderArr[i][0]);//better than above ch 

                    ///var che = "apple".ToUpper();
                    ///var ch3 = che.ToLower();//this can also be done

                    builderArr[i].Remove(0, 1);
                    builderArr[i].Insert(0, new string(ch2, 1));
                }
            }

            var strArrFinal = new String[strArr.Length];
            for (var i = 0; i < strArr.Length; i++)
            {
                strArrFinal[i] = Convert.ToString(builderArr[i]);
            }

            var hungarian = String.Join("", strArrFinal);
            return hungarian;
        }




        public void Exercise4()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            //var variableName = "";
            //foreach (var word in input.Split(' '))
            //{
            //    var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            //    variableName += wordWithPascalCase;
            //}

            var strArr = input.Split(' ');
            var variableName = "";
            for (var i=0; i<strArr.Length; i++)
            {
                if (i == 0)
                {
                    var wordWithPascalCase ="_" + char.ToLower(strArr[i][0]) + strArr[i].ToLower().Substring(1);
                    variableName += wordWithPascalCase;
                }
                else
                {
                    var wordWithPascalCase =char.ToUpper(strArr[i][0]) + strArr[i].ToLower().Substring(1);
                    variableName += wordWithPascalCase;
                }
            }
            Console.WriteLine(variableName);
        }
    }
}

