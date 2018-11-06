using System;

namespace DesignPatterns
{
    public abstract class Middleware : IMiddleware
    {
        public DateTime CreateDate { get ; set; }

        public abstract void DoAction();
    }
}
