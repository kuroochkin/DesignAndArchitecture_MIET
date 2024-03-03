namespace LR5.Abstraction
{
    /// <summary>
    /// Абстрактный интерпретатор
    /// </summary>
    public abstract class AbstractInterpreter
    {
        /// <summary>
        /// Строка введенного текста
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public abstract string Interpret(string text);
    }
}