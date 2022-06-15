using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Calcular
    {
        public static double Validar()
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
        public static double Sumar(double a, double b)
        {
            return a + b;
        }
        public static double Multiplicacion(double a, double b)
        {
            return a * b;
        }
        public static double Resta(double a, double b)
        {
            return a - b;
        }
        public static double Division(double a, double b)
        {
            while (b == 0)
            {
                Clear();
                Write("");
                WriteLine("No es posible dividir entre cero");
                WriteLine("");
                Write("Ingrese un divisor diferente de cero");
                b = Validar();
            }
            return a / b;
        }
    }
}
