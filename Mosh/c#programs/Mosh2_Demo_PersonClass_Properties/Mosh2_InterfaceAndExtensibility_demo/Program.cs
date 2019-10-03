using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2_InterfaceAndExtensibility_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new ConsoleLogger());
            //var dbMigrator = new DBMigrator(new FileLogger("C:\\Users\\suman\\Desktop\\Mosh\\c#programs\\fileHandling\\xyz.txt"));
            dbMigrator.Migrate();
            Console.ReadKey();
        }
    }
}
