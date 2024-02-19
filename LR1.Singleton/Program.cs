using System;

namespace LR1.Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            
            Console.WriteLine("singleton1 и singleton2 являются одним и тем же объектом: " + (singleton1 == singleton2));
            
            singleton1.SomeMethod();
        }
    }
}