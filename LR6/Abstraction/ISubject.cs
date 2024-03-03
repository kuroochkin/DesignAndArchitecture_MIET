namespace LR6.Abstraction
{
    /// <summary>
    /// Абстракция наблюдаемого объекта
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Оформление подписки для наблюдателя
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        void RegisterObserver(IObserver observer);
        
        /// <summary>
        /// Удаление подписки для наблюдателя
        /// </summary>
        /// <param name="observer">Объект наблюдателя</param>
        void RemoveObserver(IObserver observer);
        
        /// <summary>
        /// Рассылка уведомлений для подписчиков
        /// </summary>
        /// <param name="progress"></param>
        void NotifyObservers(CurrentProgress progress);
    }
}