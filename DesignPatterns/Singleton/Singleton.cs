using System;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;

        public String Name;

        public Singleton()
        {
            Name = "Single Instance";
        }

        public static Singleton SingleInstance {
            get {
                if (_instance == null) _instance = new Singleton();
                return _instance;
            }
        }
    }
}
