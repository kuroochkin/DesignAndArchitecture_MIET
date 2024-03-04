using System.Collections.Generic;
using LR2.Builders.PassengerBuilder.Abstraction;
using LR2.Entities.Passengers.Abstraction;
using LR2.Entities.Passengers.Realization;
using LR2.Enums;

namespace LR2.Builders.PassengerBuilder.Realization
{
    public class BusPassengerBuilder : IPassengerBuilder
    {
        private readonly List<Passenger> _passengers = new List<Passenger>();

        public Passenger BuildPassenger(PassengerCategory category)
        {
            var passenger = new BusPassenger() { Category = category };
            _passengers.Add(passenger);
            return passenger;
        }
        public List<Passenger> GetPassengers() =>  _passengers;
    }
}