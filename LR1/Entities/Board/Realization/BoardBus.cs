using System;
using System.Collections.Generic;
using LR1.Entities.Board.Abstraction;
using LR1.Entities.Drivers.Realization;
using LR1.Entities.Passengers;

namespace LR1.Entities.Board.Realization
{
    public class BoardBus : BoardAnyCar
    {
        public override List<Passenger> Passengers { get; set; } = new List<Passenger>();
        public override int MaxPassengersCount { get; set; } = 30;

        public override bool BoardDriver(Driver driver)
        {
            if (driver is BusDriver)
            {
                Console.WriteLine("Водитель автобуса добавлен.");
                return true;
            }
            else
            {
                Console.WriteLine("Водитель не добавлен. Не подходит категория.");
                return false;
            }
        }

        public override bool BoardPassenger(Passenger passenger)
        {
            if (Passengers.Count < MaxPassengersCount)
            {
                Passengers.Add(passenger);
                Console.WriteLine($"Пассажир {passenger.Name} добавлен в автобус.");
                return true;
            }
            else
            {
                Console.WriteLine("Пассажир не добавлен в автобус. Превышен лимит пассажиров.");
                return false;
            }
        }
    }
}