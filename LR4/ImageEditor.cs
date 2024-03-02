using LR4.Abstraction;
using LR4.Realization;

namespace LR4;

public sealed class MainForm : Form
{
    /// <summary>
    /// Бокс
    /// </summary>
    private Rectangle _box;
    
    /// <summary>
    /// Объект изображения
    /// </summary>
    private IImage? _imageProxy;
    
    /// <summary>
    /// Является ли сообщение загруженным
    /// </summary>
    private bool _imageLoaded;

    /// <summary>
    /// Конструктор формы
    /// </summary>
    public MainForm()
    {
        _imageProxy = null;
        _imageLoaded = false;

        this.DoubleBuffered = true;
        this.Paint += MainForm_Paint;
        this.MouseDown += MainForm_MouseDown;
        this.MouseMove += MainForm_MouseMove;

        InitializeBox();
    }

    /// <summary>
    /// Инициализация бокса, подготовка рамки для будущей загрузки сообщения
    /// </summary>
    private void InitializeBox()
    {
        _imageProxy = new ImageProxy("D:\\proga\\pattern_MIET\\DesignAndArchitecture_MIET\\LR4\\Images\\image.jpg");
        Size imageSize = _imageProxy.GetImageSize();
        _box = new Rectangle(50, 50, imageSize.Width, imageSize.Height);
    }

    /// <summary>
    /// Метод отрисовки бокса
    /// </summary>
    /// <param name="sender">Объект, вызывающий событие</param>
    /// <param name="e">Событие клика компьютерной мышью</param>
    private void MainForm_Paint(object? sender, PaintEventArgs e)
    {
        e.Graphics.DrawRectangle(Pens.Black, _box);
        if (_imageLoaded && _imageProxy != null)
        {
            _imageProxy.Draw(e.Graphics, _box);
        }
    }

    /// <summary>
    /// Метод загрузки реального изображения
    /// </summary>
    /// <param name="sender">Объект, вызывающий событие</param>
    /// <param name="e">Событие клика компьютерной мышью</param>
    private void MainForm_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e is { Button: MouseButtons.Right, Clicks: 2 })
        {
            _imageLoaded = true;
            this.Invalidate();
        }
    }

    /// <summary>
    /// Метод перемещения бокса
    /// </summary>
    /// <param name="sender">Объект, вызывающий событие</param>
    /// <param name="e">Событие клика компьютерной мышью</param>
    private void MainForm_MouseMove(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            _box.X = e.X - _box.Width / 2;
            _box.Y = e.Y - _box.Height / 2;
            this.Invalidate();
        }
    }
}
