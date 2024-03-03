namespace LR6.Abstraction
{
    /// <summary>
    /// Абстракция объекта-наблюдателя
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Метод для получения обновленной информации
        /// </summary>
        /// <param name="progress">Объект успеваемости</param>
        void Update(CurrentProgress progress);
    }
}