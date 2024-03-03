using LR5.Abstraction;

namespace LR5.Realization
{
    /// <summary>
    /// Интерпретатор для исправления дефиса вместо тире
    /// </summary>
    public class DashInterpreter : AbstractInterpreter
    {
        /// <summary>
        /// Метод для исправления тире на дефис
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public override string Interpret(string text) 
            => text.Replace("—", "-");
    }
}