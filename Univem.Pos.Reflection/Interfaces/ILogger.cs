using System;

namespace Univem.Pos.Reflection.Interfaces
{
    public interface ILogger
    {
        void Log(String msg, Exception e, Object obj);

    }
}
