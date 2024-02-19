using System;
using LR3.Composite;
using LR3.Leaf;

namespace LR3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Создание самолета
            var aircraft = new AircraftClass();

            // Добавление пилотов и стюардесс
            aircraft.Add(new Pilot());
            aircraft.Add(new Pilot());
            for (int i = 0; i < 6; i++)
            {
                aircraft.Add(new Stewardess());
            }

            // Создание классов пассажиров
            var firstClass = new FirstClass();
            var businessClass = new BusinessClass();
            var economyClass = new EconomyClass();

            // Добавление пассажиров в классы
            firstClass.Add(new Passenger(40)); 
            businessClass.Add(new Passenger(25)); 
            economyClass.Add(new Passenger(15)); 

            // Добавление классов в самолет
            aircraft.Add(firstClass);
            aircraft.Add(businessClass);
            aircraft.Add(economyClass);
            
            aircraft.Display(1);
            firstClass.Display(1);
            businessClass.Display(1);
            economyClass.Display(1);

            // Расчет макимально доступного веса
            double totalBaggageWeightRules =
                firstClass.MaxTotalWeight + businessClass.MaxTotalWeight + economyClass.MaxTotalWeight;

            Console.WriteLine($"Максимальный допустимый вес: {totalBaggageWeightRules} кг.");

            // Расчет общего веса багажа
            double totalBaggageWeight = firstClass.GetBaggageWeight() +
                                        businessClass.GetBaggageWeight() +
                                        economyClass.GetBaggageWeight();
            Console.WriteLine($"Общий вес багажа: {totalBaggageWeight} кг");

            // Проверка на превышение максимальной допустимой загрузки багажом и снятие лишнего багажа у пассажиров эконом класса
            if (totalBaggageWeight > totalBaggageWeightRules)
                Console.WriteLine($"Превышение максимально допустимого веса багажа на {totalBaggageWeight - totalBaggageWeightRules} кг.");
                
            double excessWeight = totalBaggageWeight - totalBaggageWeightRules;
            
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (excessWeight > 0)
            {
                // Проходим по каждому пассажиру эконом класса
                foreach (var passenger in economyClass.GetPassengers())
                {
                    double passengerBaggageWeight = passenger.GetBaggageWeight();
                    
                    passenger.SetBaggageWeight(passengerBaggageWeight - 10);

                    Console.WriteLine($"Удаление {passengerBaggageWeight - 10} кг багажа у пассажира эконом класса.");

                    // Если избыточный вес уменьшился до нуля, выходим из цикла
                    if (excessWeight <= 0)
                    {
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}