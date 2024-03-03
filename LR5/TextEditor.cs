using System.Collections.Generic;
using LR5.Abstraction;
using LR5.Realization;

namespace LR5
{
    /// <summary>
    /// Текстовый редактор
    /// </summary>
    public class TextEditor
    {
        /// <summary>
        /// Список всех обработчиков ошибок
        /// </summary>
        private readonly List<AbstractInterpreter> _interpreters;

        /// <summary>
        /// Конструктор для текстового редактора
        /// </summary>
        public TextEditor()
        {
            _interpreters = new List<AbstractInterpreter>();
            InterpretersRegistration();
        }

        /// <summary>
        /// Регситрация всех обработчиков ошибок
        /// </summary>
        private void InterpretersRegistration()
        {
            _interpreters.Add(new MultipleSpaceInterpreter());
            _interpreters.Add(new DashInterpreter());
            _interpreters.Add(new QuotesInterpreter());
            _interpreters.Add(new TabInterpreter());
            _interpreters.Add(new SpaceBeforePunctuationInterpreter());
            _interpreters.Add(new MultipleLineBreaksInterpreter());
        }
        
        /// <summary>
        /// Метод для исправления всех ошибок в тексте
        /// </summary>
        /// <param name="text">Введенный текст</param>
        /// <returns>Исправленный текст</returns>
        public string FixText(string text)
        {
            foreach (var interpreter in _interpreters)
                text = interpreter.Interpret(text);
            
            return text;
        }
    }
}