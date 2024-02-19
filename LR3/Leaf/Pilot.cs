using System;
using LR3.Component;

namespace LR3.Leaf
{
    public class Pilot : IPassenger
    {
        public void Add(IPassenger component)
        {
            Console.WriteLine("Пилоты не могут иметь дополнительных компонентов.");
        }

        public void Remove(IPassenger component)
        {
            Console.WriteLine("Пилоты не могут иметь дополнительных компонентов.");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Пилот");
        }

        public double GetBaggageWeight()
        {
            return 0;
        }
        
        public void SetBaggageWeight(double weight)
        {
            // Пустая реализация метода SetBaggageWeight
        }
    }
}