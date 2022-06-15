using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Division
    {
        public double Dividir(double guardado, bool save = false)
        {
            Validacion val = new Validacion();
            double memoria = guardado;
            double a;
            if (save)
            {
                a = memoria;
                WriteLine($"numero 1:{a}");
            }
            else
            {
                Write("Numero 1:");
                a = val.Validar();
            }

            Write("Numero 2:");
            double b = val.Validar();
            while (b == 0)
            {
                Clear();
                WriteLine("!!!!!!!No es posible dividir entre cero!!!!!!");
                WriteLine("Ingrese un divisor diferente de cero");
                Write($"{a}/");
                b = val.Validar();
            }

            Write($"{a}/{b}={a / b}");
            return a / b;
        }
    }
}
