using LR1.Entities.AbstractFactory.Abstraction;
using LR1.Entities.Board.Abstraction;
using LR1.Entities.Board.Realization;
using LR1.Entities.Drivers.Realization;

namespace LR1.Entities.AbstractFactory.Realization
{
    public class BusFactory : TransportFactory
    {
        public override Driver CreateDriver()
        {
            return new BusDriver();
        }

        public override BoardAnyCar CreateBoarder()
        {
            return new BoardBus();
        }
    }
}