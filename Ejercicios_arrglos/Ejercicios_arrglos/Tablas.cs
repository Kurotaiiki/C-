using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ejercicios_arrglos
{
    internal class Tablas
    {
        public void Operar()
        {
            int num1, num2;

            num1 = new PedirDatos().IntData(true, "numero 1");
            num2 = new PedirDatos().IntData(true, "numero 2");


            for (int i = num1; i <= num2; i++)
            {
                Write($"\n//  \tTabla del {i}  \t//\n");
                for (int j = 1; j <= 12 ; j++)
                {
                    Write($"||  {i}x{j}={i*j}  \t||\n");
                }
            }


        }
    }
}
