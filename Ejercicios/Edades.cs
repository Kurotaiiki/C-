using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Ejercicios
{
    internal class Edades
    {
        public void Calculate()
        {
            int edad = new PedirDato().IntDate("edad");

            if (edad<18)
            {
                Write("\nTodavia eres un niño");
            }
            else if(edad<31)
            {
                Write("\nYa eres un adulto");
            }
            else if (edad < 61)
            {
                Write("\nYa eres un veterano");
            }
            else
            {
                Write("\nYa eres un viejo");
            }

        }
    }
}
