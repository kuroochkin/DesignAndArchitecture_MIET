using System;
using System.Collections.Generic;
using LR2.Entities.Board.Abstraction;
using LR2.Entities.Drivers.Abstraction;
using LR2.Entities.Drivers.Realization;
using LR2.Entities.Passengers;
using LR2.Entities.Passengers.Abstraction;
using LR2.Entities.Passengers.Realization;

namespace LR2.Entities.Board.Realization
{
    public class BoardTaxi : BoardAnyCar
    {
        public override List<Passenger> Passengers { get; set; } = new List<Passenger>();
        public override Driver Driver { get; set; }
        public override int MaxPassengersCount { get; set; } = 4;

        public override bool BoardDriver(Driver driver)
        {
            if (driver is TaxiDriver)
            {
                Driver = driver;
                Console.WriteLine("Водитель такси добавлен.");
                return true;
            }

            return false;
        }

        public override bool BoardPassenger(Passenger passenger)
        {
            if (Passengers.Count < MaxPassengersCount && passenger is TaxiPassenger)
            {
                Passengers.Add(passenger);
                Console.WriteLine($"Пассажир {passenger.Name} с категорией {passenger.Category} добавлен в такси.");
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