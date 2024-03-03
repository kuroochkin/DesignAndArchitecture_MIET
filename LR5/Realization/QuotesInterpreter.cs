using System.Text;
using System.Text.RegularExpressions;
using LR5.Abstraction;

namespace LR5.Realization
{
    /// <summary>
    /// Интерпретатор для исправления кавычек
    /// </summary>
    class QuotesInterpreter : AbstractInterpreter
    {
        /// <summary>
        /// Метод для исправления кавычек
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public override string Interpret(string text) 
            => Regex.Replace(text, "\"([^\"]*)\"", "«$1»");
    }
}