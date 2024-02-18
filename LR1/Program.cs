using System.Collections.Generic;
using LR1.Entities.AbstractFactory.Abstraction;
using LR1.Entities.AbstractFactory.Realization;
using LR1.Entities.Passengers;

namespace LR1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      TransportFactory busFactory = new BusFactory();
      TransportFactory taxiFactory = new TaxiFactory();

      var busDriver = busFactory.CreateDriver();
      var taxiDriver = taxiFactory.CreateDriver();

      var busPassengers = new List<Passenger>() { new Passenger(), new Passenger(), new Passenger() };
      var taxiPassengers = new List<Passenger>() { new Passenger(), new Passenger(), new Passenger() };

      var boardBus = busFactory.CreateBoarder();
      boardBus.BoardDriver(busDriver);
      
      foreach (var passenger in busPassengers)
      {
        boardBus.BoardPassenger(passenger);
      }

      var boardTaxi = taxiFactory.CreateBoarder();
      boardTaxi.BoardDriver(taxiDriver);

      foreach (var passenger in taxiPassengers)
      {
        boardTaxi.BoardPassenger(passenger);
      }
    }
  }
}