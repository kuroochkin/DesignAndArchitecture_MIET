using System;
using System.Linq;
using System.Text;
using LR2.Builders.BoardBuilder.Abstraction;
using LR2.Entities.Board.Realization;
using LR2.Entities.Drivers.Abstraction;
using LR2.Entities.Drivers.Realization;
using LR2.Entities.Passengers;

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
                _boardBus.Driver = driver;
                Console.WriteLine("Водитель автобуса добавлен.");
                return true;
            }
            else
            {
                Console.WriteLine("Водитель в автобус не добавлен. Водитель уже есть.");
                return false;
            }
        }

        public bool AddPassenger(Passenger passenger)
        {
            if (_boardBus.Passengers.Count < _boardBus.MaxPassengersCount)
            {
                _boardBus.Passengers.Add(passenger);
                Console.WriteLine($"Пассажир {passenger.Name} с категорий {passenger.Category} добавлен в автобус.");
                return true;
            }
            else
            {
                Console.WriteLine("Пассажир не добавлен в автобус. Превышен лимит пассажиров.");
                return false;
            }
        }

        public void Go()
        {
            if (_boardBus.Driver != null) 
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