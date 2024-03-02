using LR4.Abstraction;

namespace LR4.Realization;

/// <summary>
/// Реальное изображение в боксе
/// </summary>
class RealImage : IImage
{
    /// <summary>
    /// Путь по которому лежит изображение
    /// </summary>
    private readonly string _filePath;
    
    /// <summary>
    /// Объект размера сообщения
    /// </summary>
    private readonly Size _size;

    /// <summary>
    /// Конструктор RealImage 
    /// </summary>
    /// <param name="filePath">Расположение изображения на диске</param>
    public RealImage(string filePath)
    {
        _filePath = filePath;
        using var img = Image.FromFile(_filePath);
        _size = img.Size;
    }

    /// <summary>
    /// Отрисовка изображения в заданном контуре
    /// </summary>
    /// <param name="graphics">Встроенный объект для отрисовки элементов</param>
    /// <param name="rectangle">Программный бокс</param>
    public void Draw(Graphics graphics, Rectangle rectangle)
    {
        var image = Image.FromFile(_filePath);
        graphics.DrawImage(image, rectangle);
    }
    
    /// <summary>
    /// Метод получения размера загружаемого изображения
    /// </summary>
    /// <returns>Размеры изображения</returns>
    public Size GetImageSize() => _size;
}