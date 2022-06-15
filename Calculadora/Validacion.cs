using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Validacion
    {
        public double Validar()
        {
            string numero = ReadLine();
            double n;
            while (!double.TryParse(numero, out n))
            {
                Clear();
                Write("");
                WriteLine("Recuerde que deben ser un numero!!!!");
                numero = ReadLine();
            }

            return n;
        }
    }
}
