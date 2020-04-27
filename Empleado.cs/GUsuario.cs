using System;
namespace Empleado.cs
{
    public partial class GUsuario : Gtk.Window
    {
        public GUsuario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
