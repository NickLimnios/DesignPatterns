using System;

namespace DesignPatterns
{
    public interface IMiddleware
    {
        DateTime CreateDate { get; set; }
        void DoAction();
    }
}
