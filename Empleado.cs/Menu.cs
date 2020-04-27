using System;
namespace Empleado.cs
{
    public partial class Menu : Gtk.Window
    {
        public Menu() :
                base(Gtk.WindowType.Toplevel)
        {
            Build();
        }

        protected void OnBtnGEmpleadoClicked(object sender, EventArgs e)
        {
            Empleado.cs.gestionEmpleados gestE = new Empleado.cs.gestionEmpleados();
            gestE.Show();
        }

        protected void OnBtnGVacacionesClicked(object sender, EventArgs e)
        {
            Empleado.cs.GVacaciones gVac = new Empleado.cs.GVacaciones();
            gVac.Show();
        }

        protected void OnBtnGEmpleadosClicked(object sender, EventArgs e)
        {
            Empleado.cs.GEmpleado gEmpleado = new Empleado.cs.GEmpleado();
            gEmpleado.Show();
        }

        protected void OnBtnBajaEmpleadoClicked(object sender, EventArgs e)
        {
            Empleado.cs.BEmpleado bEmpleado = new Empleado.cs.BEmpleado();
            bEmpleado.Show();
        }

        protected void OnBtnCEMpleadoClicked(object sender, EventArgs e)
        {
            Empleado.cs.CEmpleado cEmpleado = new Empleado.cs.CEmpleado();
            cEmpleado.Show();
        }

        protected void OnBtnPNominaClicked(object sender, EventArgs e)
        {
            Empleado.cs.PNomina pNomina = new Empleado.cs.PNomina();
            pNomina.Show();
        }

        protected void OnBtnGBonoClicked(object sender, EventArgs e)
        {
            Empleado.cs.GBonos gEmpleado = new Empleado.cs.GBonos();
            gEmpleado.Show();
        }

        protected void OnBtnGDeduccionesClicked(object sender, EventArgs e)
        {
            Empleado.cs.GDeducciones gDeducciones = new Empleado.cs.GDeducciones();
            gDeducciones.Show();
        }

        protected void OnBtnGEmpresaClicked(object sender, EventArgs e)
        {
            Empleado.cs.GEmpresa gEmpresa = new Empleado.cs.GEmpresa();
            gEmpresa.Show();
        }

        protected void OnBtnGDepartamentoClicked(object sender, EventArgs e)
        {
            Empleado.cs.GDepartamentosandPlazas gDepPlazas = new Empleado.cs.GDepartamentosandPlazas();
            gDepPlazas.Show();
        }

        protected void OnBtnGContratoClicked(object sender, EventArgs e)
        {
            Empleado.cs.GContratos gContratos = new Empleado.cs.GContratos();
            gContratos.Show();
        }

        protected void OnBtnGPlazaClicked(object sender, EventArgs e)
        {
            Empleado.cs.GPlazas gPlazas = new Empleado.cs.GPlazas();
            gPlazas.Show();
        }

        protected void OnBtnGUsuariosClicked(object sender, EventArgs e)
        {
            Empleado.cs.GUsuario gUsuario = new Empleado.cs.GUsuario();
            gUsuario.Show();
        }

        protected void OnBtnCHorariosClicked(object sender, EventArgs e)
        {
            Empleado.cs.CHorarios cHorarios = new Empleado.cs.CHorarios();
            cHorarios.Show();
        }

        protected void OnBtnGMonedasClicked(object sender, EventArgs e)
        {
            Empleado.cs.GMoneda gMoneda = new Empleado.cs.GMoneda();
            gMoneda.Show();
        }
    }
}


