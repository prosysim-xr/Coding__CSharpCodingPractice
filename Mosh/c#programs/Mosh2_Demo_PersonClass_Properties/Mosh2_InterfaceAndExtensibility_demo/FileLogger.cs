using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Mosh2_InterfaceAndExtensibility_demo
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            //since streamwriter not managed by CLR, we need to ..using thingie
            //var streamWriter = new StreamWriter(_path, true);[//SteamWriter(_path, whether we like to append)]
            //streamWriter.Dispose();//to dispose resource that are not managed by CLR we dpont have to do that by using "using"
            //using (var streamWriter = new StreamWriter(_path, true))
            //{
            //    streamWriter.WriteLine("error" + message);

            //}

            Log(message, "Error");


        }

        public void LogInfo(string message, DateTime now)
        {
            Log(message, "Info");
        }

        //below code because DRY principle
        //along with it enumeration for messageType is going to be important thing
        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ":" + message);

            }
        }
    }
}
