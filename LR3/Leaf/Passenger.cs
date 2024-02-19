using System;
using LR3.Component;

namespace LR3.Leaf
{
    class Passenger : IPassenger
    {
        private double _baggageWeight;

        public Passenger(double baggageWeight)
        {
            _baggageWeight = baggageWeight;
        }

        public void Add(IPassenger component)
        {
            Console.WriteLine("Пассажиры не могут иметь дополнительных компонентов.");
        }

        public void Remove(IPassenger component)
        {
            Console.WriteLine("Пассажиры не могут иметь дополнительных компонентов.");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Пассажир с весом багажа: " + _baggageWeight + " кг");
        }

        public double GetBaggageWeight()
        {
            return _baggageWeight;
        }
        
        public void SetBaggageWeight(double weight)
        {
            _baggageWeight = weight;
        }
    }
}