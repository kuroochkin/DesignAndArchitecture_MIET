namespace LR4.Abstraction;

/// <summary>
/// Абстракция изображения, появляющегося в боксе
/// </summary>
interface IImage
{
    /// <summary>
    /// Отрисовка изображения в заданном контуре
    /// </summary>
    /// <param name="graphics">Встроенный объект для отрисовки элементов</param>
    /// <param name="rectangle">Программный бокс</param>
    void Draw(Graphics graphics, Rectangle rectangle);
    
    /// <summary>
    /// Метод получения размера загружаемого изображения
    /// </summary>
    /// <returns>Размеры изображения</returns>
    Size GetImageSize();
}