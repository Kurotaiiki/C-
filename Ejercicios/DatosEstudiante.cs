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
            string nombre = new PedirDato().Texto("nombre");
            string apellido = new PedirDato().Texto("apellido");
            string direccion = new PedirDato().Texto("direccion");
            string ciudad = new PedirDato().Texto("ciudad");
            string cedula = new PedirDato().Texto("cedula");
            string edad = new PedirDato().Texto("edad");

            WriteLine("");
        } 
    }
}
