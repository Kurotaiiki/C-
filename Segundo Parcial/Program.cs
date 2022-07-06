using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Segundo_Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vendedores = 0;

            Write("Cuantos vendedores son .:");
            vendedores = int.Parse(ReadLine());

            string[] nombres = new Vendedor().Nombres(vendedores);
            int[] ventas = new Vendedor().Ventas(vendedores);
            double[] vlrVentas = new Vendedor().VlrVentas(vendedores);
            double[] total = new Vendedor().TotalVentas(ventas,vlrVentas);
            double[] bono = new Vendedor().Bono(total);
            WriteLine("\n|NOMBRE\t|Cantidad\t|VlrUnitario\t\t|Total\t\t|BONO\t");

            for (int i = 0; i < vendedores; i++)
            {
                WriteLine($"|{nombres[i]}\t|{ventas[i]}\t\t|{vlrVentas[i]}\t\t\t|{total[i]}\t|{bono[i]}");
            }

            WriteLine($"Promedio de ventas = {(total.Sum())/vendedores}");
            WriteLine($"Ventas Totales = {total.Sum()}");




            ReadKey();
        }
    }
}
