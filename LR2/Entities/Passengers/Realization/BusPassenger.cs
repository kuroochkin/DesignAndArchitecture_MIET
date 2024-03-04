using LR2.Entities.Passengers.Abstraction;
using LR2.Enums;

namespace LR2.Entities.Passengers.Realization
{
    public class BusPassenger : Passenger
    {
        public override string Name { get; set; }
        
        public override PassengerCategory Category { get; set; }
    }
}