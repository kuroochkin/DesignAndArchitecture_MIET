namespace LR6
{
    /// <summary>
    /// Текущая успеваемость
    /// </summary>
    public class CurrentProgress
    {
        /// <summary>
        /// Номер группы
        /// </summary>
        public string GroupName { get; private set; }
        
        /// <summary>
        /// Дисциплина
        /// </summary>
        public string Discipline { get; private set; }
        
        /// <summary>
        /// Временной статус отправки
        /// </summary>
        public AddProgressInTimeStatus AddProgressInTimeStatus { get; private set; }

        /// <summary>
        /// Конструктор для успеваемости
        /// </summary>
        /// <param name="groupName">Номер группы</param>
        /// <param name="discipline">Дисциплина</param>
        /// <param name="addProgressInTimeStatus">Временной статус отправки</param>
        public CurrentProgress(
            string groupName, 
            string discipline, 
            AddProgressInTimeStatus addProgressInTimeStatus)
        {
            GroupName = groupName;
            Discipline = discipline;
            AddProgressInTimeStatus = addProgressInTimeStatus;
        }
    }

    /// <summary>
    /// Состояние отправки
    /// </summary>
    public enum AddProgressInTimeStatus
    {
        Success,
        NotSuccess
    }
}