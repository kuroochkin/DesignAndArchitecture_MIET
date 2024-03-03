using System;

namespace LR5
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var editor = new TextEditor();
            
            string textWithErrors = "Пример   с множественным  пробелом.    Юго—западный.  Ресторан \"Меркурий\"." +
                                    "   Табуляция. \n\n\n Текст упал вниз(";
            
            var fixedText = editor.FixText(textWithErrors);
            
            Console.WriteLine("Исходный текст:");
            Console.WriteLine(textWithErrors);
            Console.WriteLine("\nИсправленный текст:");
            Console.WriteLine(fixedText);
        }
    }
}