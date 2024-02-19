namespace LR3.Composite
{
    public class FirstClass : AircraftClass
    {
        protected override int MaxCountPassengers => 10;
        protected override double MaxWeightForPassenger => 50;

        protected override string GetClassName() => "Первый класс";
    }
}