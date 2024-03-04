using LR2.Entities.Drivers.Abstraction;
using LR2.Entities.Passengers;
using LR2.Entities.Passengers.Abstraction;


namespace LR2.Builders.BoardBuilder.Abstraction
{
    public interface IBoardBuilder
    {
        bool AddDriver(Driver driver);
        bool AddPassenger(Passenger passenger);
        void Go();
    }
}