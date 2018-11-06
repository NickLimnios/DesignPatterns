using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class CareTaker<T> where T : ICloneable
    {
        private static List<Memento<T>> mementoList = new List<Memento<T>>();

        public static void SaveState(Originator<T> orig)
        {
            mementoList.Add(orig.CreateMemento());
        }

        public static void RestoreState(Originator<T> orig, int checkpoint)
        {
            orig.RestoreMemento(mementoList[checkpoint]);
        }
    }
}