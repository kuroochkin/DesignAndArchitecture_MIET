using System.Text.RegularExpressions;
using LR5.Abstraction;

namespace LR5.Realization
{
    /// <summary>
    /// Интерпретатор для удаления лишних пробелов после пунктуации
    /// </summary>
    public class SpaceBeforePunctuationInterpreter : AbstractInterpreter
    {
        /// <summary>
        /// Метод для удаления лишних пробелов после знаков пунктуации
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public override string Interpret(string text) 
            => Regex.Replace(text, @"\s+([.,!?])", "$1");
    }
}