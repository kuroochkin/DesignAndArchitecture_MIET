using LR2.Entities.Drivers.Abstraction;
using LR2.Entities.Passengers;


namespace LR2.Builders.BoardBuilder.Abstraction
{
    public interface IBoardBuilder
    {
        bool AddDriver(Driver driver);
        bool AddPassenger(Passenger passenger);
        void Go();
    }
}