using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
              TestSingleton();

              TestFactory();

              TestMemento();
        }

        /// <summary>
        /// A singleton is a class which only allows a single instance of it to be created. 
        /// In the application runtime, only one single instance of the singleton class will exist for all users.
        /// </summary>
        private static void TestSingleton()
        {
            Singleton singleton = Singleton.SingleInstance;

            Console.WriteLine($"Singleton Name is : {singleton.Name}");
            Console.ReadKey();

        }

        /// <summary>
        /// This is a creational pattern that uses a specialized object to create other objects,
        /// abstracting the use of concrete objects. This is a pattern extensivelly used in
        /// strategies to reduce coupling in the code.
        /// </summary>
        private static void TestFactory()
        {
            MiddlewareFactory factory = new MiddlewareFactory();
            IMiddleware middleware = factory.GetMiddleware<Middleware1>();
            middleware.DoAction();

            middleware = factory.GetMiddleware<Middleware2>();
            middleware.DoAction();

            Console.ReadKey();
        }

        /// <summary>
        /// The memento Design Pattern provide means to keep track of the states of an object.
        /// </summary>
        private static void TestMemento()
        {
            Originator<StateObject> current = new Originator<StateObject>();

            current.SetState(new StateObject { Id = 1, Name = "Object1" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 2, Name = "Object2" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            current.SetState(new StateObject { Id = 3, Name = "Object3" });
            CareTaker<StateObject>.SaveState(current);
            current.ShowState();

            CareTaker<StateObject>.RestoreState(current,0);
            current.ShowState();

            Console.ReadKey();
        }
    }
}
