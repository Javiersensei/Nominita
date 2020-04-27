using System;
namespace Empleado.cs
{
    public partial class GVacaciones : Gtk.Window
    {
        public GVacaciones() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnReducirDiasClicked(object sender, EventArgs e)
        {

        }
    }
}
