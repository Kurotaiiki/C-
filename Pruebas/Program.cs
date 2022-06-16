using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                //declarar las variables
                double num2=0, num1 = 0;


                //creo la variable objeto de la clase
                ClassSuma ObjSum = new ClassSuma();

                bool salir = false;
                while (!salir)
                {


                    Console.WriteLine("Elige una opcion");
                    Console.WriteLine("1. suma");
                    Console.WriteLine("2. resta");
                    Console.WriteLine("3. multiplicacion");
                    Console.WriteLine("4. division");
                    Console.WriteLine("5. salir");
                    Console.Write("-->");

                    int opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion != 5)
                    {
                        WriteLine("Digite el primer numero ");
                        num1 = double.Parse(Console.ReadLine());

                        WriteLine("digite segundo numero");
                        num2 = double.Parse(Console.ReadLine());
                    }

                    switch (opcion)
                    {

                        case 1:
                            WriteLine("\nhas elegido la opcion 1");
                            //Realizar la suma
                            ObjSum.MostrarResultado(ObjSum.SumarNumeros(num1, num2));
                            break;

                        case 2:
                            WriteLine("\nhas elegido la opcion 2");
                            //Realizar la resta
                            ObjSum.MostrarResultado(ObjSum.RestarNumeros(num1, num2));
                            break;

                        case 3:
                            WriteLine("\nhas elegido opcion 3");
                            //Realizar la multiplicacion
                            ObjSum.MostrarResultado(ObjSum.MultiplicarNumeros(num1, num2));
                            break;

                        case 4:
                            WriteLine("\nhas elegido opcion 4");
                            //Realizar la division
                            ObjSum.MostrarResultado(ObjSum.DividirNumeros(num1, num2));
                            break;

                        case 5:
                            WriteLine("\nHas elegido salir del programa");
                            salir = true;
                            break;


                        default:
                            WriteLine("\nelige una opcion del 1 al 5");
                            break;
                    }
                }
            }
    }
}
