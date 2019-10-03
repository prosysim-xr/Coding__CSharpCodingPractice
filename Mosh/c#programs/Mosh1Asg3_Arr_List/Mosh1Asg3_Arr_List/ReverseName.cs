using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh1Asg3_Arr_List
{
    class ReverseName
    {
        public void Reverse()
        {
            
            Console.WriteLine("plese enter a name\n");
            var nameStr = Console.ReadLine();

            //we used previous nameStr
            var nameArr = new char[nameStr.Length];
            for (var i = 0; i < nameStr.Length; i++)
            {
                nameArr[i] = nameStr[i];
            }
            //we used previous nameArr
            var nameArr2 = new char[nameArr.Length];
            for (var i = 0; i < nameStr.Length; i++)
            {
                nameArr2[(nameStr.Length-1)-i] = nameArr[i];
            }
            //we used nameStr and nameArr to store into new separate sring using new keyword
            var nameStr2 = new string(nameStr.Reverse().ToArray());
            var nameStr3 = new string(nameArr2);
            
            Console.WriteLine(nameStr2);
            Console.WriteLine(nameStr3);
            for (var i = 0; i < nameStr3.Length; i++)
            {
                Console.WriteLine(nameStr3[i]);
            }
            //___________cannot update a string bc it is read only_______________
            //var nameStr3 = new string(nameStr2.ToArray());
            //for (var i = 0; i < nameArr.Length; i++)
            //{
            //    nameStr3[i] = nameArr[i];
            //}
            //______________________________________________________________________
            //_____________foreach-syntax____________________
            //foreach(var ichar in nameStr2)
            //{
            //    Console.WriteLine(ichar);
            //}

            //__________________some syntax ________________
            //String s1 = "C# Example";
            //Char[] s3 = s1.ToCharArray();
            //_______________________________________________
        }
    }
}
