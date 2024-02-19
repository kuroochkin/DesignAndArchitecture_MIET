using System;

namespace LR1.Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        public static Singleton GetInstance() => instance ?? (instance = new Singleton());
        public void SomeMethod() => Console.WriteLine("Вызван метод SomeMethod()");
    }
}