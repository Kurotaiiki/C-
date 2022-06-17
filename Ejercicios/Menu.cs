using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Ejercicios
{
    internal class menu
    {
        List<string> list_opciones = new List<string>();
        public int Crear(Array nombreOpciones)
        {
            int opcion;
            foreach (string op in nombreOpciones)
            {
                list_opciones.Add(op);
            }
            Array arr_opciones = list_opciones.ToArray();


            WriteLine("Escoga la opcion que desee\n");

            Imprime(arr_opciones);
            
            Write("\nIngrese su opcion :.");

            while (!int.TryParse(ReadLine(), out opcion) || opcion < 1 || opcion > arr_opciones.Length)
            {
                Clear();
                WriteLine("La opcion no es valida, por favor ingrese una opcion valida");
                Imprime(arr_opciones);
                Write("\nIngrese su opcion  :.");
            }


            
            return opcion;

        }

        private void Imprime(Array arr_opciones)
        {
            int i = 1;
            foreach (string opcion in arr_opciones)
            {
                WriteLine($"{i}.{opcion}");
                i++;
            }
        }
    }
}
