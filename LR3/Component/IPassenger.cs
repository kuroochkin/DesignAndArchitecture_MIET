namespace LR3.Component
{
    public interface IPassenger
    {
        void Add(IPassenger passenger);
        void Remove(IPassenger passenger);
        void Display(int depth);
        double GetBaggageWeight();
        void SetBaggageWeight(double weight);
    }
}