using System;
using System.Windows.Forms;
using Main.Tools;

namespace Main
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Hacking.InitSoftware(Config.StartMode, args.Length == 1 ? args[0] : null);
                new FormBackground();
                Application.Run();
            }
            catch { }
        }
    }
}
