using System;
namespace Empleado.cs
{
    public partial class GMoneda : Gtk.Window
    {
        public GMoneda() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
