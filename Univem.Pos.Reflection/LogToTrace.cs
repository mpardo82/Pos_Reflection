using System.Diagnostics;
using Univem.Pos.Reflection.Interfaces;

namespace Univem.Pos.Reflection
{
    public class LogToTrace : ILoggerOutput
    {
        public void setMessage(string msg)
        {
            Trace.TraceInformation(msg);
        }
    }
}
