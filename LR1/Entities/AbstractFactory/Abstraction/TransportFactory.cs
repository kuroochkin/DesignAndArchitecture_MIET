using LR1.Entities.Board.Abstraction;

namespace LR1.Entities.AbstractFactory.Abstraction
{
    public abstract class TransportFactory
    {
        public abstract Driver CreateDriver();
        public abstract BoardAnyCar CreateBoarder();
    }
}