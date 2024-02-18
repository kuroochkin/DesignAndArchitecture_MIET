using LR2.Enums;

namespace LR2.Entities.Passengers.Realization
{
    public class TaxiPassenger : Passenger
    {
        public override string Name { get; set; }
        
        public override PassengerCategory Category { get; set; }
        
        public bool HasBabyChair { get; set; }
    }
}