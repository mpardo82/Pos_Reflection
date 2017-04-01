using System;
using Univem.Pos.Reflection.Interfaces;

namespace Univem.Pos.Reflection
{
    public class Logger : LoggerBase, ILogger
    {
        ILoggerOutput output;
        public Logger(ILoggerOutput saida)
        {
            this.output = saida;
        }

        public void Log(string msg, Exception e, object obj)
        {
            output.setMessage(String.Format("{0} - {1}", msg, e.Message));
            output.setMessage(base.Log(obj));
        }
    }
    
}

