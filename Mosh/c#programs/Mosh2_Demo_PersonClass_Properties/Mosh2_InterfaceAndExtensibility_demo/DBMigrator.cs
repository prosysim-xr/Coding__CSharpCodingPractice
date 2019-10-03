using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mosh2_InterfaceAndExtensibility_demo
{
    public class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger) //dependency injection
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("migration started at {0}", DateTime.Now);
            // details of migrating the data base
            _logger.LogInfo("migration started at {0}", DateTime.Now);
        }
    }
}
