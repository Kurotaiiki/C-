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
            bool ejecutar = true;
            string[] opciones = new string[] {"Saludo","Datos del estudiante","Suma","Operaciones basicas","Comparar","Calculos","Cuadratica","Areas","Salario","Mayor de edad"};
            string[] opcionesFinal = new string[] {"Reiniciar","Salir"};
            while (ejecutar)
            {
                int  opcion  = new Menu().Crear(opciones);
                Clear();
                switch (opcion)
                {
                    case 1:
                        new Saludo().Saludar();
                        break;
                    case 2:
                        new DatosEstudiante().Datos();
                        break;
                    case 3:
                        new OperacionesBasicas().Suma();
                        break;

                    case 4:
                        new OperacionesBasicas().MostrarTodas();
                        break;
                    
                    case 5:
                        new CompararNumeros().Comparar();
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                    case 10:
                        break;
                    default:
                        WriteLine("Por defecto");
                        break;
                }

                opcion = new Menu().Crear(opcionesFinal);
                Clear();

                switch(opcion)
                {
                    case 1:
                        break;
                    case 2:
                        ejecutar = false;
                        break;
                }

            }














            ReadKey();
        }
    }
}
