using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Facturacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Cuantos productos vamos a manejar .:");
            int totalUnits=new PedirDato().IntDate("",false);
            Products products = new Products();
            Factura factura = new Factura();
            int[] units= new int[totalUnits];

            for (int i = 0; i < totalUnits; i++)
            {
                products.Create(new PedirDato().StringDate($"nombre del producto {i+1}"), new PedirDato().DoubleDate("precio del producto"));
                Write("Cuantas unidades se vendieron.:");
                units[i]=(new PedirDato().IntDate("",false));
                factura.Add(units[i] * products.See()[i].price);                
            }


            Write("Num.---------Descripcion------VlrUnit------Cantidad-----------VlrTotal\n\n");

            for (int i = 0; i < totalUnits; i++)
            {
                WriteLine($"{i + 1}\t\t{products.See()[i].name}\t\t{products.See()[i].price}\t\t{units[i]}\t\t{(products.See()[i].price) * (units[i])}");
            }

            Write("\n");
            factura.Calculate();
            factura.Show();

            ReadKey();
        }
    }
}
