using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_Demo_PersonClass_Properties
{
    public class Person
    {
        //Auto Properties
        public string P_name { get; set; }
        public string P_userName { get; set; }
        public DateTime P_birthDate { get; private set; }// because  private set

        //Declared Properties
        ////<--------------------------------->
        //private DateTime _birthDate;

        //public DateTime P_birthdate
        //{
        //    get { return _birthDate; }
        //    set { _birthDate = value; }
        //}
        ////<--------------------------------->

        //ctor
        public Person(DateTime _birthDate)// this ctor because  private setter below
        {
            P_birthDate = _birthDate;
        }

        //calculated Properties
        public int P_age
        {
            get
            {
                var timeSpan = DateTime.Today - P_birthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
            ///we dont want to set age here we already in a way 
            ///did that when we put our birthdate. It is void of
            ///common sense if we did that
        }

    }
}
