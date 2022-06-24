using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Facturacion
{
    internal class Factura
    {
        double subtotal=0;
        double iva = 0;
        double total = 0;
        double sale = 0;
        double neto = 0;


        public void Add(double price)
        {
            subtotal+=price;
        }

        void Iva()
        {
            iva = subtotal*0.19;
        }
        void Total()
        {
            total = iva + subtotal;
        }

        void Sale()
        {
            if (total>500000)
            {
                sale = total * 0.1;
            }
        }

        void Neto()
        {
            neto = total - sale;
        }

        public void Calculate()
        {
            Iva();
            Total();
            Sale();
            Neto();
        }
        
        public void Show()
        {
            Write($"Subtotal-------{subtotal}\n" +
                  $"Iva------------{iva}\n" +
                  $"Total Factura--{total}\n" +
                  $"Descuento------{sale}\n" +
                  $"Neto-----------{neto}");
        }





    }
}
