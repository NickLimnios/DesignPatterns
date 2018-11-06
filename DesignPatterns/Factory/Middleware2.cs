using System;

namespace DesignPatterns
{
    public class Middleware2 : Middleware
    {
        public override void DoAction()
        {
            Console.WriteLine("Executing action from Middleware2.");
        }
    }
}
