using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Segundo_Parcial
{
    internal class Vendedor
    {
        public string[] Nombres(int cuantos)
        {
            string[] nombres = new string[cuantos];

            for (int i = 0; i < nombres.Length; i++)
            {
                Write($"Ingrese el nombre del vendedor {i+1} .:");
                nombres[i] =ReadLine();
            }

            return nombres;
        }
        public int[] Ventas(int n)
        {
            int[] ventas = new int[n];

            for (int i = 0; i < ventas.Length; i++)
            {
                Write($"Ingrese las ventas del vendedor {i+1} .:");
                ventas[i] = int.Parse(ReadLine());
            }

            return ventas;
        }

        public double[] VlrVentas(int n)
        {
            double[] ventas = new double[n];

            for (int i = 0; i < ventas.Length; i++)
            {
                Write($"Ingrese el valor de la mercancia del vendedor {i+1} .:");
                ventas[i] = double.Parse(ReadLine());
            }

            return ventas;
        }


        public double[] TotalVentas(int[] ventas,double[] valor)
        {
            double[] total = new double[valor.Length];

            for (int i = 0; i < ventas.Length; i++)
            {
                total[i] = ventas[i] * valor[i];
            }

            return total;
        }

        public double[] Bono(double[] total)
        {
            double[] ventas = new double[total.Length];

            for (int i = 0; i < total.Length; i++)
            {
                if (total[i] >= 1000000 && total[i] <= 1250000 )
                {
                    ventas[i] =(total[i] * 0.1);
                }
                else if (total[i] > 1250000 && total[i] <= 2000000)
                {
                    ventas[i] = (total[i] * 0.15);
                }
                else if (total[i] > 2000000)
                {
                    ventas[i] =(total[i] * 0.1);
                }
            }

            return ventas;
        }




    }
}
