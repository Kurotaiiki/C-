using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            menu menu = new menu();
            bool ejecutar = true;
            string[] opciones =new string[] {"Saludo","Datos del estudiante","Suma","Operaciones basicas","Comparar","Calculos","Cuadratica","Areas","Salario","Mayor de edad"};
            int  opcion  = menu.Crear(opciones);
            Clear();
            while (ejecutar)
            {
                switch (opcion)
                {
                    case 1:
                        new Saludo().Saludar();
                        break;
                    case 2:
                        new DatosEstudiante().Datos();
                        break;

                    case 2:
                        new OperacionesBasicas().Datos();
                        break;

                    default:
                        WriteLine("Por defecto");
                        break;
                }
            }














            ReadKey();
        }
    }
}
