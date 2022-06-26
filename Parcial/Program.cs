using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaramos nuestras variables

            //logicas
            bool ejecutar = true;
            int opcion = 0;
            bool imprimir = true;
            List<string> list_nombres= new List<string>();
            int productos;


            //pedir el numero de productos del catalago

            Write("Cuantos productos se venden .:");
            while(!int.TryParse(ReadLine(),out productos))
            {
                Write("Ingrese un precio valido, recuerde no usar letras ni caracteres especiales\n.:");
            }

            //arreglo de nombres |1.Jean | 2.Tenis | 3.Blusas | 
            string[] nombres = new string[productos];


            //arreglo de precios |1.Jean | 2.Tenis | 3.Blusas | 
            double[] precios= new double[productos];

            //arreglo de unidades|1.Jean | 2.Tenis | 3.Blusas | 
            int[] unidades = new int[productos];


            for (int i = 0; i < productos; i++)
            {
                Write($"Ingrese el nombre del producto{i + 1} .:");
                list_nombres.Add(ReadLine());
            }

            nombres = list_nombres.ToArray();

            for (int i = 0; i < nombres.Length; i++)
            {
                Write($"Ingrese el valor de l@s {nombres[i]} .:");
                while (!double.TryParse(ReadLine(), out precios[i]))
                {
                    Write("Ingrese un precio valido, recuerde no usar letras ni caracteres especiales\n.:");
                }
            }


            // Asignamos los precios unitarios de cada producto
            do
            {
                if (imprimir)
                {
                    Clear();
                    MenuVentas(nombres);
                    opcion = int.Parse(ReadLine());
                }
                else
                {
                    Clear();
                    Write("!!!! Ingrese una opcion adecuada!!!!");
                    MenuVentas(nombres);
                    opcion = int.Parse(ReadLine());
                }

                if (opcion>nombres.Length || opcion < 1)
                {
                    imprimir = false;
                }
                else
                {
                    Write($"Cuant@s {nombres[opcion - 1]} se vendieron .:");
                    unidades[opcion - 1] += int.Parse(ReadLine());
                }
                
                if (opcion==nombres.Length+1)
                {
                    ejecutar = false;
                }
               

                

                

            } while (ejecutar);



            WriteLine("Num.--------Descripcion\t\tvlr Unit\tCantidad\tVlr Total");
            for (int i = 0; i < nombres.Length; i++)
            {
                WriteLine($"{i+1}.----------{nombres[i]}\t\t{precios[i]}\t\t{unidades[i]}\t\t{precios[i] * unidades[i]}");
            }

            Write("\n");

            new Facturacion().Calcular(precios,unidades);



            //Fin del programa 

            ReadKey();
        }

        //Funciones 
        private static void MenuVentas(string[] nombres)
        {
            
            WriteLine("Que producto se vendio");
            for (int i = 0; i < nombres.Length; i++)
            {
                WriteLine($"{i + 1}.{nombres[i]}");
            }
            WriteLine($"{nombres.Length + 1}.Facturacion");
            Write("opcion .:");

        }
    }
}
