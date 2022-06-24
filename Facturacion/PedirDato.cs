using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Facturacion
{
    internal class PedirDato
    {
        public string StringDate(string nombreDato = "Nombre del Dato", bool conNombre = true)
        {
            if (conNombre)
            {
                Write($"Ingrese el {nombreDato} .:");

            }


            return Console.ReadLine();
        }
        public int IntDate(string nombreDato = "Nombre del Dato", bool conNombre = true)
        {
            int numero;
            if (conNombre)
            {
                Write($"Ingrese su {nombreDato} .:");
            }

            while (!int.TryParse(ReadLine(), out numero))
            {
                WriteLine("El dato ingresado no es valido,unicamente pueden ser valores numericos enteros");
                if (conNombre)
                {
                    Write($"Ingrese su {nombreDato} .:");
                }
            }

            return numero;
        }
        public double DoubleDate(string nombreDato = "Nombre del Dato", bool conNombre = true)
        {
            double numero;
            if (conNombre)
            {
                Write($"Ingrese su {nombreDato} .:");
            }

            while (!double.TryParse(ReadLine(), out numero))
            {
                WriteLine("El dato ingresado no es valido unicamente pueden ser valores numericos(double)");
                if (conNombre)
                {
                    Write($"Ingrese su {nombreDato} .:");
                }
            }

            return numero;
        }
        public float FloatDate(string nombreDato = "Nombre del Dato", bool conNombre = true)
        {
            float numero;
            if (conNombre)
            {
                Write($"Ingrese su {nombreDato} .:");
            }

            while (!float.TryParse(ReadLine(), out numero))
            {
                WriteLine("El dato ingresado no es valido unicamente pueden ser valores numericos(float)");
                if (conNombre)
                {
                    Write($"Ingrese su {nombreDato} .:");
                }
            }

            return numero;
        }
    }
}
