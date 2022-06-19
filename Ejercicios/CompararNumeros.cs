using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class CompararNumeros
    {

        public void Comparar()
        {
            //variables fijas
            double mayor;
            double menor;
            int medio;
            double promedio = 0;


            //Pedimos los datos
            Write("cuantos numeros desea comparar :.");
            int veces = new PedirDato().Entero("", false);

            //Generamos el arreglo de numeros
            double[] arr_numeros = new double[veces];

            for (int i = 0; i < veces; i++)
            {
                Write($"Ingrese el numero {i + 1} :.");
                arr_numeros[i] = new PedirDato().Doble("", false);
            }

            arr_numeros = _ordenar(arr_numeros,true);



            //hallamos mayor y menor
            mayor = _comparar(arr_numeros);
            menor = _comparar(arr_numeros, "menor");
            medio = arr_numeros.Length / 2;


            //Sacamos el promedio
            for (int i = 0; i < veces; i++)
            {
                promedio += arr_numeros[i];
            }

            _imprimir(mayor, menor, medio, arr_numeros,"ascendente");


        }

        private static void _imprimir(double mayor, double menor, int medio, double[] arr_numeros,string orden)
        {
            Write($"\n\n Lista {orden}\n|");
            if (arr_numeros.Length % 2 != 0)
            {
                for (int i = 0; i < arr_numeros.Length; i++)
                {
                    if (i == 0)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                        Write($"{arr_numeros[i]}");
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;



                    }
                    else if (i == medio)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                        Write($"{arr_numeros[i]}");
                    }
                    else if (i == arr_numeros.Length - 1)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                        Write($"{arr_numeros[i]}");
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;
                        Write("|");
                    }
                    else
                    {
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;
                        Write($"|{arr_numeros[i]}|");
                    }
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;



                }
                WriteLine($"\n\n|Mayor {mayor}|| Menor {menor} || Medio {medio + 1}\n\n");
            }
            else
            {
                for (int i = 0; i < arr_numeros.Length; i++)
                {
                    if (i == 0)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                        Write($"{arr_numeros[i]}");
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;


                    }
                    else if (i == medio)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                        Write($"{arr_numeros[i]}");
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;
                        Write("|");
                    }
                    else if (i == medio - 1)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                        Write($"{arr_numeros[i]}");
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;
                        Write("|");
                    }
                    else if (i == arr_numeros.Length - 1)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                        Write($"{arr_numeros[i]}");
                        BackgroundColor = ConsoleColor.Black;
                        ForegroundColor = ConsoleColor.White;

                        Write("|");
                    }
                    else
                    {

                        Write($"|{arr_numeros[i]}|");
                    }
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;



                }
                WriteLine($"\n\nMayor {mayor}|| Menor {menor} || Medio {medio}<->{medio + 1}\n\n");
            }
        }

        private double _comparar(double[] arr_numeros,string mayorMenor="mayor")
        {
            double menor = 1.8 * 100000000;
            double mayor = -1.8 * 100000000;

            for (int i = 0; i < arr_numeros.Length; i++)
            {
                if (arr_numeros[i] > mayor)
                {
                    mayor = arr_numeros[i];
                }
                if (arr_numeros[i] < menor)
                {
                    menor = arr_numeros[i];
                }
            }
            if (mayorMenor=="mayor")
            {
                return mayor;
            }

            return menor;
        }

        private double[] _ordenar(double[] arr_numeros,bool ascendente=true)
        {

            List<double> list_numeros = arr_numeros.ToList<double>();
            List<double> list_ordenada = new List<double>();

            if (ascendente)
            {
             
                for (int i = 0; i < arr_numeros.Length; i++)
                {
                    for (int j = 0; i < list_numeros.Count; i++)
                    {
                        Write("entre "+ list_numeros.ToArray<double>() );
                        list_ordenada.Add(_comparar(list_numeros.ToArray<double>(),"menor"));
                        list_numeros.Remove(_comparar(list_numeros.ToArray<double>(),"menor"));
                    }
                    
                }

                
            }
            else
            {
                for (int i = 0; i < arr_numeros.Length; i++)
                {
                    double[] arr_temp = list_numeros.ToArray();
                    list_numeros.Add(_comparar(arr_numeros));
                }
            }

            return list_ordenada.ToArray();

        }



    }
}
