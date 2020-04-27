using System;
namespace Empleado.cs
{
    public partial class PNomina : Gtk.Window
    {
        public PNomina() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
