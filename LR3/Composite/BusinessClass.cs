namespace LR3.Composite
{
    public class BusinessClass : AircraftClass
    {
        protected override int MaxCountPassengers => 20;
        protected override double MaxWeightForPassenger => 35;
        protected override string GetClassName()
        {
            return "Бизнес класс";
        }
    }
}