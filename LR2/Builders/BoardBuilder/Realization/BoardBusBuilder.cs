using System;
using System.Linq;
using System.Text;
using LR2.Builders.BoardBuilder.Abstraction;
using LR2.Entities.Board.Realization;
using LR2.Entities.Drivers.Abstraction;
using LR2.Entities.Drivers.Realization;
using LR2.Entities.Passengers;
using LR2.Entities.Passengers.Abstraction;

namespace LR2.Builders.BoardBuilder.Realization
{
    public class BoardBusBuilder : IBoardBuilder
    {
        private readonly BoardBus _boardBus;

        public BoardBusBuilder()
        {
            _boardBus = new BoardBus();
        }

        public bool AddDriver(Driver driver)
        {
            if (driver is BusDriver && _boardBus.Driver == null)
            {
                return _boardBus.BoardDriver(driver);
            }
            else
            {
                Console.WriteLine("Водитель не добавлен. Водитель уже есть либо не подходит категория.");
                return false;
            }
        }

        public bool AddPassenger(Passenger passenger)
        {
            if (passenger != null && _boardBus.Passengers.Count < _boardBus.MaxPassengersCount)
            {
                return _boardBus.BoardPassenger(passenger);
            }

            return false;
        }

        public void Go()
        {
            if (_boardBus.Driver == null) 
                Console.WriteLine("Маршрут не может начаться без водителя.");
            
            if (_boardBus.Passengers.Count == 0)
                Console.WriteLine("Маршрут не может начаться без пассажиров");

            var result = new StringBuilder();
            result.Append("Маршрут начался!")
                .AppendLine($"Водитель автобуса с категорий {_boardBus.Driver.Category} на месте")
                .AppendLine("Пассажиры: ");

            foreach (var passenger in _boardBus.Passengers)
                result.AppendLine($"Пассажир с категорией {passenger.Category.ToString()}");

            result.AppendLine($"Общее количество пассажиров: {_boardBus.Passengers.Count()}");

            Console.WriteLine(result.ToString());
        }
    }
}