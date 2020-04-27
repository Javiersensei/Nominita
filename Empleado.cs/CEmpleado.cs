using System;
namespace Empleado.cs
{
    public partial class CEmpleado : Gtk.Window
    {
        public CEmpleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
