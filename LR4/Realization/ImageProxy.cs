using LR4.Abstraction;

namespace LR4.Realization;

/// <summary>
/// Proxy(заместитель) для реального изображения в боксе
/// </summary>
class ImageProxy : IImage
{
    private readonly RealImage _realImage;

    /// <summary>
    /// ImageProxy
    /// </summary>
    /// <param name="filePath">Расположение изображения на диске</param>
    public ImageProxy(string filePath)
    {
        _realImage = new RealImage(filePath);
    }

    /// <summary>
    /// Отрисовка изображения в заданном контуре
    /// </summary>
    /// <param name="graphics">Встроенный объект для отрисовки элементов</param>
    /// <param name="rectangle">Программный бокс</param>
    public void Draw(Graphics graphics, Rectangle rectangle) => _realImage.Draw(graphics, rectangle);

    /// <summary>
    /// Метод получения размера загружаемого изображения
    /// </summary>
    /// <returns>Размеры изображения</returns>
    public Size GetImageSize() => _realImage.GetImageSize();
}