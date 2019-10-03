using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg_DBConnection
{
    class OracleConnection : DBConnection
    {

        public OracleConnection(string strCon)
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

            if (TimeSpan.FromSeconds(ran.Next(1, 5)) >= _timeOut)
            {
                throw new Exception("invalid stringConnection");
            }
            else if (String.IsNullOrWhiteSpace(P_stringConnection)|| P_stringConnection!= "oracle")
            {
                throw new Exception("invalid stringConnection");
            }
            else if (P_stringConnection == "oracle")
            {
                Console.WriteLine("OpenDB will Open the DB");
            }
            
        }
    }
}
