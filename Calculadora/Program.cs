using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calc = new Calcular();
            Menu menu = new Menu();
            MenuSalida salida = new MenuSalida();
            bool ejecutar = true;

            while (ejecutar)
            {
                menu.Crear(calc);
                ejecutar= salida.crear(calc);                
            }
        }

    }
}
