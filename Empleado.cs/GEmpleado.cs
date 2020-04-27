using System;
namespace Empleado.cs
{
    public partial class GEmpleado : Gtk.Window
    {
        public GEmpleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
