using System;
using System.Collections.Generic;
using LR3.Component;

namespace LR3.Composite
{
    public class AircraftClass : IPassenger
    {
        private List<IPassenger> _passengers = new List<IPassenger>();
        protected virtual int MaxCountPassengers => 100;
        protected virtual double MaxWeightForPassenger => 0;
        
        public double MaxTotalWeight => MaxCountPassengers * MaxWeightForPassenger;
        
        public void Add(IPassenger component)
        {
            if (_passengers.Count < MaxCountPassengers)
            {
                _passengers.Add(component);
            }
            else
            {
                Console.WriteLine($"Превышено максимальное количество пассажиров: {MaxCountPassengers}");
            }
        }

        public void Remove(IPassenger component)
        {
            _passengers.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " " + GetClassName());

            foreach (var component in _passengers)
            {
                component.Display(depth + 2);
            }
        }

        public double GetBaggageWeight()
        {
            double totalBaggageWeight = 0;
            foreach (var passenger in _passengers)
            {
                totalBaggageWeight += passenger.GetBaggageWeight();
            }
            return totalBaggageWeight;
        }

        public List<IPassenger> GetPassengers() => _passengers;
        
        public void SetBaggageWeight(double weight)
        {
            foreach (var passenger in _passengers)
            {
                passenger.SetBaggageWeight(weight);
            }
        }
        
        protected virtual string GetClassName()
        {
            return "Самолет";
        }
    }
}