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
    public class BoardBus : BoardAnyCar
    {
        public override List<Passenger> Passengers { get; set; } = new List<Passenger>();
        
        public override Driver Driver { get; set; }
        public override int MaxPassengersCount { get; set; } = 30;

        public override bool BoardDriver(Driver driver)
        {
            if (driver is BusDriver)
            {
                Driver = driver;
                Console.WriteLine("Водитель автобуса добавлен.");
                return true;
            }

            return false;
        }

        public override bool BoardPassenger(Passenger passenger)
        {   
            if (Passengers.Count < MaxPassengersCount && passenger is BusPassenger) 
            {
                Passengers.Add(passenger);
                Console.WriteLine($"Пассажир {passenger.Name} с категорий {passenger.Category} добавлен в автобус.");
                return true;
            }
            else
            {
                Console.WriteLine("Пассажир не добавлен в автобус. Превышен лимит пассажиров " +
                                  "или не подходящий пассажир");
                return false;
            }
        }
    }
}