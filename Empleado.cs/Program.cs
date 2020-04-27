using System;
using Gtk;

namespace Empleado.cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            //MainWindow win = new MainWindow();
            //win.Show();
            Empleado.cs.Menu mn = new Empleado.cs.Menu();
            mn.Show();
            Application.Run();
        }
    }
}
