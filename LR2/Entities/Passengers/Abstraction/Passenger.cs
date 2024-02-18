using LR2.Enums;

namespace LR2.Entities.Passengers
{
    public abstract class Passenger
    {
        public abstract string Name { get; set; }
        public abstract PassengerCategory Category { get; set; }
    }
}