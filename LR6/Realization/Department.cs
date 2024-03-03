using System;
using LR6.Abstraction;

namespace LR6.Realization
{
    /// <summary>
    /// Кафедра, является наблюдателем деканата
    /// </summary>
    public class Department : IObserver
    {
        /// <summary>
        /// Метод для получения обновленной информации от деканата
        /// </summary>
        /// <param name="progress">Объект успеваемости</param>
        public void Update(CurrentProgress progress)
        {
            Console.WriteLine($"Кафедра получила уведомление от декана: Преподаватель невовремя опубликовал успеваемость " +
                              $"для группы {progress.GroupName} по дисциплине {progress.Discipline}. Статус: {progress.AddProgressInTimeStatus}");
        }
    }
}