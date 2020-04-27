using System;
namespace Empleado.cs
{
    public partial class GEmpresa : Gtk.Window
    {
        public GEmpresa() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
