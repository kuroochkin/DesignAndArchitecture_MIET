namespace LR4;

static class Program
{
    /// <summary>
    ///  Точка старта приложения
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}