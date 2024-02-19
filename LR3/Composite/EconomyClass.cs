namespace LR3.Composite
{
    public class EconomyClass : AircraftClass
    {
        protected override int MaxCountPassengers => 150;
        protected override double MaxWeightForPassenger => 20;

        protected override string GetClassName()
        {
            return "Эконом класс";
        }

        public double GetMaxWeightForPassenger() => MaxWeightForPassenger;

    }
}