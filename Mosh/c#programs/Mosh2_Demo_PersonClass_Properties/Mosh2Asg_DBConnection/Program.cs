using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg_DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter oracle or sql");
            var strCon = Console.ReadLine();
            var oracleObj = new OracleConnection(strCon);
            var sqlObj = new SQLConnection(strCon);
            if (strCon == "oracle")
            {
                
                oracleObj.OpenDB();
                Console.WriteLine("Done stuff in Oracle db");
                oracleObj.CloseDB();
            }

            if (strCon == "sql")
            {
                
                sqlObj.OpenDB();
                Console.WriteLine("Done stuff in sql db");
                sqlObj.CloseDB();
                Console.ReadKey();
            }

            var dbcmd = new DBCommand("execute this comd", sqlObj);
           
        }
    }
}
