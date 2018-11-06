using System;

namespace DesignPatterns
{
    public class Middleware1 : Middleware
    {
        public override void DoAction()
        {
            Console.WriteLine("Executing action from Middleware1");
        }
    }
}
