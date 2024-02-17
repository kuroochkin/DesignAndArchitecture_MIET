using System.Collections.Generic;
using LR1.Entities.Passengers;

namespace LR1.Entities.Board.Abstraction
{
    public abstract class BoardAnyCar
    {
        public abstract List<Passenger> Passengers { get; set; }
        public abstract int MaxPassengersCount { get; set; }
        public abstract bool BoardDriver(Driver driver);
        public abstract bool BoardPassenger(Passenger passengers);
    }
}