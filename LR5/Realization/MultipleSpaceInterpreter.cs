using System.Text.RegularExpressions;
using LR5.Abstraction;

namespace LR5.Realization
{
    /// <summary>
    /// Интерпретатор для исправления множественных пробелов
    /// </summary>
    public class MultipleSpaceInterpreter : AbstractInterpreter
    {
        /// <summary>
        /// Метод для исправления множественных пробелов
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public override string Interpret(string text) 
            => Regex.Replace(text, @"\s+", " ");
    }
}