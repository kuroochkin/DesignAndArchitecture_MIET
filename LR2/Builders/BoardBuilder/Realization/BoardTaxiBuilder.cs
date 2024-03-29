using System;
using System.Linq;
using System.Text;
using LR2.Builders.BoardBuilder.Abstraction;
using LR2.Entities.Board.Realization;
using LR2.Entities.Drivers.Abstraction;
using LR2.Entities.Drivers.Realization;
using LR2.Entities.Passengers.Abstraction;

namespace LR2.Builders.BoardBuilder.Realization
{
    public class BoardTaxiBuilder : IBoardBuilder
    {
        private readonly BoardTaxi _boardTaxi;
        
        public BoardTaxiBuilder()
        {
            _boardTaxi = new BoardTaxi();
        }

        public bool AddDriver(Driver driver)
        {
            if (driver is TaxiDriver && _boardTaxi.Driver == null)
            {
                return _boardTaxi.BoardDriver(driver);
            }
            else
            {
                Console.WriteLine("Водитель не добавлен. Водитель уже есть либо не подходит категория.");
                return false;
            }
        }

        public bool AddPassenger(Passenger passenger)
        {
            if (_boardTaxi.Passengers.Count < _boardTaxi.MaxPassengersCount)
            {
                return _boardTaxi.BoardPassenger(passenger);
            }

            return false;
        }
        
        public void Go()
        {
            if (_boardTaxi.Driver == null) 
                Console.WriteLine("Маршрут не может начаться без водителя.");
            
            if (_boardTaxi.Passengers.Count == 0)
                Console.WriteLine("Маршрут не может начаться без пассажиров.");

            var result = new StringBuilder();
            result.Append("Маршрут начался! ")
                .AppendLine($"Водитель такси с категорий {_boardTaxi.Driver.Category} на месте.")
                .AppendLine("Пассажиры: ");

            foreach (var passenger in _boardTaxi.Passengers)
            {
                result.AppendLine($"Пассажир с категорией {passenger.Category.ToString()}. ");
            }

            result.AppendLine($"Общее количество пассажиров: {_boardTaxi.Passengers.Count()}.");

            Console.WriteLine(result.ToString());
        }
    }
}