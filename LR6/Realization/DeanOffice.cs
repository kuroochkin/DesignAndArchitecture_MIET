using System;
using System.Collections.Generic;
using LR6.Abstraction;

namespace LR6.Realization
{
    /// <summary>
    /// Деканат, является наблюдателем преподавателей и наблюдаемым объектом для кафедры
    /// </summary>
    public class DeanOffice : IObserver, ISubject
    {
        /// <summary>
        /// Список наблюдателей деканата
        /// </summary>
        private readonly List<IObserver> _observers = new List<IObserver>();

        /// <summary>
        /// Оформление подписки на деканат
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        public void RegisterObserver(IObserver observer) 
            => _observers.Add(observer);

        /// <summary>
        /// Удаление подписки на деканат
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        public void RemoveObserver(IObserver observer) 
            => _observers.Remove(observer);

        /// <summary>
        /// Получение информации от издателей
        /// </summary>
        /// <param name="progress">Объект успеваемости</param>
        public void Update(CurrentProgress progress)
        {
            Console.WriteLine($"Декан получил уведомление: Преподаватель отправил успеваемость " +
                              $"для группы {progress.GroupName} по дисциплине {progress.Discipline}. Статус: {progress.AddProgressInTimeStatus}");
            
            NotifyObservers(progress);
        }

        /// <summary>
        /// Рассылка уведомлений для подписчиков
        /// </summary>
        /// <param name="progress">Объект успеваемости</param>
        public void NotifyObservers(CurrentProgress progress)
        {
            if (progress.AddProgressInTimeStatus == AddProgressInTimeStatus.NotSuccess)
            {
                foreach (var observer in _observers)
                {
                    observer.Update(progress);
                }
            }
        }
    }
}