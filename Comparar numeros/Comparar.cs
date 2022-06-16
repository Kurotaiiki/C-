using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comparar_numeros
{
    internal class Comparar
    {
        public int mayor;
        public void Compare(int actual)
        {
            if (actual > mayor)
            {
                mayor = actual;
            }
        }
        public void MostrarMayor()
        {
            Console.WriteLine($"El numero {mayor} es el mayor");
        }
    }
}
