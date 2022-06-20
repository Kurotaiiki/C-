using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Ejercicios
{
    internal class PedirDato
    {
        public string Texto(string nombreDato="Nombre del Dato",bool conNombre =  true)
        {
            if (conNombre)
            {
                Write($"Ingrese su {nombreDato}");
            }
            
            return Console.ReadLine();
        }
        public int Entero(string nombreDato = "Nombre del Dato", bool conNombre = true)
        {
            int numero;
            if (conNombre)
            {
                Write($"Ingrese su {nombreDato} :.");
            }

            while (!int.TryParse(ReadLine(),out numero))
            {
                WriteLine("El dato ingresado no es valido");
            }

            return numero;
        }
        public double Doble(string nombreDato = "Nombre del Dato", bool conNombre = true)
        {
            double numero;
            if (conNombre)
            {
                Write($"Ingrese su {nombreDato} :.");
            }

            while (!double.TryParse(ReadLine(), out numero))
            {
                WriteLine("El dato ingresado no es valido");
            }

            return numero;
        }
    }
}
