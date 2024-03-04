using System.Collections.Generic;
using LR2.Entities.Passengers;
using LR2.Entities.Passengers.Abstraction;
using LR2.Enums;

namespace LR2.Builders.PassengerBuilder.Abstraction
{
    public interface IPassengerBuilder
    {
        /// <summary>
        /// Создание пассажира c категорией билета
        /// </summary>
        Passenger BuildPassenger(PassengerCategory category);
        
        List<Passenger> GetPassengers();
    }
}