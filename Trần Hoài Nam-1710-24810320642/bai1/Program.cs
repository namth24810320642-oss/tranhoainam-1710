using System;
using System.Windows.Forms;

namespace bai1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Đảm bảo chữ F viết hoa: MainForm
            Application.Run(new MainForm());
        }
    }
}