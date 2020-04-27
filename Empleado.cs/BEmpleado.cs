using System;
namespace Empleado.cs
{
    public partial class BEmpleado : Gtk.Window
    {
        public BEmpleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
