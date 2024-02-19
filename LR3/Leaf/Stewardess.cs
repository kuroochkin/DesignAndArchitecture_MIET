using System;
using LR3.Component;

namespace LR3.Leaf
{
    public class Stewardess : IPassenger
    {
        public void Add(IPassenger component)
        {
            Console.WriteLine("Стюардессы не могут иметь дополнительных компонентов.");
        }

        public void Remove(IPassenger component)
        {
            Console.WriteLine("Стюардессы не могут иметь дополнительных компонентов.");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Стюардесса");
        }

        public double GetBaggageWeight()
        {
            return 0;
        }
        
        public void SetBaggageWeight(double weight)
        {
        }
        
        
    }
}