using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class Saludo
    {
        public void Saludar()
        {
            string nombre = new PedirDato().Texto("nombre");
            string mensaje = "Buenos dias ";
            WriteLine($"{mensaje}{nombre}");
        }
        
    }
}
