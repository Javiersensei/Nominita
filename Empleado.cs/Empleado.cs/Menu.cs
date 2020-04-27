using System;
namespace Empleado.cs
{
    public partial class Menu : Gtk.Window
    {
        public Menu() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
