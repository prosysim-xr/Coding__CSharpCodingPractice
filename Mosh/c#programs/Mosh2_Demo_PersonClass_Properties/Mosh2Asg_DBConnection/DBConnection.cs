using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg_DBConnection
{
    public abstract class DBConnection
    {
        public String P_stringConnection { get; set; }
        public TimeSpan _timeOut = TimeSpan.FromSeconds(5);

        public DBConnection(string strCon)
        {
            this.P_stringConnection = strCon;
        }

        public abstract void OpenDB();
        public abstract void CloseDB();
    }
}
