using Univem.Pos.Reflection.Interfaces;
using System;

namespace Univem.Pos.Reflection
{
    public class LogToFile : ILoggerOutput
    {
        String path;
        public LogToFile(String path)
        {
            this.path = path;
        }
        public void setMessage(string msg)
        {
            String file = String.Format("{0}/log.txt", path);

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(file, true))
            {
                sw.WriteLine(msg);
            }
        }

      
    }
}
