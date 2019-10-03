using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg_DBConnection
{
    class SQLConnection :DBConnection
    {
        public SQLConnection(string strCon)
         : base(strCon)
        {
        }

        public override void CloseDB()
        {
            Console.WriteLine("CloseDB will close the DB");
        }

        public override void OpenDB()
        {
            var ran = new Random();

            if(TimeSpan.FromSeconds(ran.Next(1, 6))>=_timeOut)
            {
                throw new Exception("invalid stringConnection");
            }
            else if (String.IsNullOrWhiteSpace(P_stringConnection) || P_stringConnection != "sql")
            {
                throw new Exception("invalid stringConnection");
            }
            else if (P_stringConnection == "sql")
            {
                Console.WriteLine("OpenDB will Open the DB");
            }
        }
    }
}
