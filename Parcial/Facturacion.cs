using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Parcial
{
    internal class Facturacion
    {


        double Subtotal(double[] precios, int[] unidades)
        {
            double subtotal = 0;

            for (int i = 0; i < precios.Length; i++)
            {
                subtotal += precios[i] * unidades[i];
            }

            return subtotal;
        }

        double Iva(double a)
        {
            return a * 0.19;
        }

        double Total(double subtotal, double iva)
        {
            return subtotal + iva;
        }

        double Descuento(double total)
        {
            double descuento = 0;
            if (total >= 500000)
            {
                descuento = total * 0.1;
            }

            return descuento;
        }

        double Neto(double total, double descuento)
        {
            return total - descuento;
        }

        public void Calcular(double[] prec,int[] unit)
        {
            double sub = Subtotal(prec,unit);
            double iva = Iva(sub);
            double total = Total(sub,iva);
            double descuento = Descuento(total);
            double neto = Neto(total, descuento);

            Write($"Subtotal:{sub}\n" +
                  $"Iva:{iva}\n" +
                  $"Total Factura:{total}\n" +
                  $"Descuento:{descuento}\n" +
                  $"Neto:{neto}");
        }



        

    }
}
