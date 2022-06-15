using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Calcular
    {
        public double memoria = 0;
        public bool save=false;
        public double Sumar()
        {
            return new Suma().Sumar(memoria, save);
        }
        public double Potenciar()
        {
            return new Potencia().Elevar(memoria, save);
        }
        public double Multiplicar()
        {
            return new Multiplicacion().Multiplicar(memoria, save);
        }
        public double Resta()
        {
            return new Resta().Restar(memoria, save);
        }
        public double Division()
        {
            return new Division().Dividir(memoria, save);
        }

    }
}
