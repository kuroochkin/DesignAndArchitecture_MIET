using LR4.Abstraction;

namespace LR4.Realization;

/// <summary>
/// Proxy(заместитель) для реального изображения в боксе
/// </summary>
class ImageProxy : IImage
{
    /// <summary>
    /// Объект реального изображения, которым управляет заместитель
    /// </summary>
    private readonly RealImage _realImage;

    /// <summary>
    /// ImageProxy
    /// </summary>
    /// <param name="realImage">Объект реального изображения</param>
    public ImageProxy(RealImage realImage) => _realImage = realImage;

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