using LR2.Builders.BoardBuilder.Realization;
using LR2.Builders.PassengerBuilder.Realization;
using LR2.Directors;
using LR2.Entities.Drivers.Realization;
using LR2.Enums;

namespace LR2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var taxiPassengerBuilder = new TaxiPassengerBuilder();
            var taxiPass1 =  taxiPassengerBuilder.BuildPassenger(PassengerCategory.Child);
            var taxiPass2 = taxiPassengerBuilder.BuildPassenger(PassengerCategory.Adult);

            var taxiDriver = new TaxiDriver();

            var taxiBoardBuilder = new BoardTaxiBuilder();
            taxiBoardBuilder.AddPassenger(taxiPass1);
            taxiBoardBuilder.AddPassenger(taxiPass2);
            taxiBoardBuilder.AddDriver(taxiDriver);
            taxiBoardBuilder.AddDriver(taxiDriver);


            var busPassengerBuilder = new BusPassengerBuilder();
            var busPass1 = busPassengerBuilder.BuildPassenger(PassengerCategory.Adult);
            var busPass2 = busPassengerBuilder.BuildPassenger(PassengerCategory.Child);
            var busPass3 = busPassengerBuilder.BuildPassenger(PassengerCategory.Discounted);

            var busDriver = new BusDriver();

            var busBoardBuilder = new BoardBusBuilder();
            busBoardBuilder.AddPassenger(busPass1);
            busBoardBuilder.AddPassenger(busPass2);
            busBoardBuilder.AddPassenger(busPass3);
            busBoardBuilder.AddDriver(busDriver);
            busBoardBuilder.AddDriver(busDriver);

            var directorTaxi = new BoardDirector(taxiBoardBuilder);
            directorTaxi.Go();
        }
    }
}