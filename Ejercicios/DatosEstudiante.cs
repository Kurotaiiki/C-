using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Ejercicios
{
    internal class DatosEstudiante
    {
        public void Datos()
        {
            string nombre = new PedirDato().StringDate("nombre");
            string apellido = new PedirDato().StringDate("apellido");
            string direccion = new PedirDato().StringDate("direccion");
            string ciudad = new PedirDato().StringDate("ciudad");
            string cedula = new PedirDato().StringDate("cedula");
            string edad = new PedirDato().StringDate("edad");

            WriteLine("");
        } 
    }
}
