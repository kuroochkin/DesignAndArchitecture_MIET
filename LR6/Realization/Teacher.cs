using System.Collections.Generic;
using LR6.Abstraction;

namespace LR6.Realization
{
    /// <summary>
    /// Преподаватель, является наблюдаемым объектом для деканата
    /// </summary>
    public class Teacher : ISubject
    {
        /// <summary>
        /// Список наблюдателей преподавателя
        /// </summary>
        private readonly List<IObserver> _observers = new List<IObserver>();
        
        /// <summary>
        /// Оформление подписки на преподавателя
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        public void RegisterObserver(IObserver observer) 
            => _observers.Add(observer);

        /// <summary>
        /// Удаление подписки на преподавателя
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        public void RemoveObserver(IObserver observer) 
            => _observers.Remove(observer);

        /// <summary>
        /// Рассылка уведомлений для подписчиков
        /// </summary>
        /// <param name="progress">Объект успеваемости</param>
        public void NotifyObservers(CurrentProgress progress)
        {
            foreach (var observer in _observers)
            {
                observer.Update(progress);
            }
        }

        /// <summary>
        /// Добавление информации об успеваемости
        /// </summary>
        /// <param name="progress">Объект успеваемости</param>
        public void AddProgress(CurrentProgress progress)
        {
            NotifyObservers(progress);
        }
    }
}