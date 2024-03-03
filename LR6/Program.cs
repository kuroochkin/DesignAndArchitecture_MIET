using LR6.Realization;

namespace LR6
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var department = new Department();
            var deanOffice = new DeanOffice();
            
            var teacher1 = new Teacher();
            var teacher2 = new Teacher();
            
            deanOffice.RegisterObserver(department);
            
            teacher1.RegisterObserver(deanOffice);
            teacher2.RegisterObserver(deanOffice);
            
            teacher1.AddProgress(new CurrentProgress
                ("ПИН-31", "Физика", AddProgressInTimeStatus.Success));
            
            teacher2.AddProgress(new CurrentProgress
                ("ПИН-33", "Защита информации", AddProgressInTimeStatus.NotSuccess));

            teacher2.AddProgress(new CurrentProgress
                ("ПИН-31", "Математика", AddProgressInTimeStatus.Success));
        }
    }
}