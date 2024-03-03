using System.Text.RegularExpressions;
using LR5.Abstraction;

namespace LR5.Realization
{
    /// <summary>
    /// Интерпретатор для исправления множественных переводов строк
    /// </summary>
    public class MultipleLineBreaksInterpreter : AbstractInterpreter
    {
        /// <summary>
        /// Метод для исправления множественных переводов строк
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public override string Interpret(string text) 
            => Regex.Replace(text, @"\n{2,}", "\n");
    }
}