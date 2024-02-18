using System.Collections.Generic;
using LR2.Entities.Drivers.Abstraction;
using LR2.Entities.Passengers;

namespace LR2.Entities.Board.Abstraction
{
    public abstract class BoardAnyCar
    {
        public abstract List<Passenger> Passengers { get; set; }
        public abstract Driver Driver { get; set; }
        public abstract int MaxPassengersCount { get; set; }
        public abstract bool BoardDriver(Driver driver);
        public abstract bool BoardPassenger(Passenger passengers);
    }
}