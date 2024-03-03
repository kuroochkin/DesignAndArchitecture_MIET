using LR5.Abstraction;

namespace LR5.Realization
{
    /// <summary>
    /// Интерпретатор для исправления табуляции
    /// </summary>
    public class TabInterpreter : AbstractInterpreter
    {
        /// <summary>
        /// Метод для исправления табуляции
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public override string Interpret(string text) 
            => text.Replace("\t", " ");
    }
}