using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Potencia
    {
        public double Elevar(double guardado, bool save = false)
        {
            Validacion val = new Validacion();
            double memoria = guardado;
            double resultado;
            double a;
            if (save)
            {
                a = memoria;
                WriteLine($"Base:{a}");
            }
            else
            {
                Write("Base:");
                a = val.Validar();

            }
            Write("Exponente:");
            double b = val.Validar();
            resultado = a;
            for (int i = 1; i < b; i++)
            {
                resultado *= a;
            }

            Write($"{a}^{b}={resultado}");
            return resultado;
        }
    }
}
