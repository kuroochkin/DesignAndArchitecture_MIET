using System;
using System.Collections.Generic;
using LR1.Entities.Board.Abstraction;
using LR1.Entities.Drivers.Realization;
using LR1.Entities.Passengers;

namespace LR1.Entities.Board.Realization
{
    public class BoardTaxi : BoardAnyCar
    {
        public override List<Passenger> Passengers { get; set; } = new List<Passenger>();
        public override int MaxPassengersCount { get; set; } = 4;

        public override bool BoardDriver(Driver driver)
        {
            if (driver is TaxiDriver)
            {
                Console.WriteLine("Водитель такси добавлен.");
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
                Console.WriteLine($"Пассажир {passenger.Name} добавлен в такси.");
                return true;
            }
            else
            {
                Console.WriteLine("Пассажир не добавлен в такси. Превышен лимит пассажиров.");
                return false;
            }
        }
    }
}