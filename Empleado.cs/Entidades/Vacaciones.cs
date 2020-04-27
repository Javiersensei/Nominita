using System;
namespace Empleado.cs.Properties
{
    public class Vacaciones
    {
        private int idVacaciones;
        private float DiasAcumulados;
        private float VacacionesPagadas;
        private float VacacionesDescanso;
        private int idEmpleados;

        public int idvacaciones { get => idVacaciones; set => idVacaciones = value; }
        public float diasacumulados { get => DiasAcumulados; set => DiasAcumulados = value; }
        public float vacacionespagadas { get => VacacionesPagadas; set => VacacionesPagadas = value; }
        public float vacacionesdescanso { get => VacacionesDescanso; set => VacacionesDescanso = value; }
        public int idempleados { get => idEmpleados; set => idEmpleados = value; }
        public Vacaciones()
        {

        }
    }
}
