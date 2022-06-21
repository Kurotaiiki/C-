using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class Cuadratica
    {
        public void Calculate()
        {
			double raiz = 0;
			double x1 = 0;
			double x2 = 0;

			WriteLine("Ingresa los valores teniendo en cuenta ax^2+bx+c\n\n");
			Write("Ingrese a .:");
			double a = new PedirDato().DoubleDate("",false);

			while (a == 0)
			{
				WriteLine("a no puede ser igual a 0\n Ingrese un nuevo valor de a .:");
				a = new PedirDato().DoubleDate("", false);
			}


			Write("Ingrese b .:");
			double b = new PedirDato().DoubleDate("", false);
			Write("Ingrese c .:");
			double c = new PedirDato().DoubleDate("", false);

			

			if ((b * b - (4 * a * c)) < 0)
			{
				WriteLine("\n\nNo es posible sacar raiz cuadrada de un numero negativo, por lo tanto la cuadratica no tiene solucion ");
			}
			else
			{
				raiz = (float)Math.Sqrt(b * b - 4 * a * c);

				x1 = (-b + raiz) / (2 * a);
				x2 = (-b - raiz) / (2 * a);

				WriteLine($"\n\nSiendo {a}x^2+{b}x+{c} \nx1 = {x1} \nx2 = {x2}");
			}

			 
        }
    }
}
