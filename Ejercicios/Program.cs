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
            CursorVisible = false;
            Menu menu = new Menu();
            Menu menu_salida = new Menu();
            bool menu_exe = true;
            int option;
            menu.Create(new string[] { "Saludo", "Datos del estudiante", "Suma", "Operaciones basicas", "Comparar", "Calculos", "Cuadratica", "Areas", "Salario", "Mayor de edad","purino me lo chupa" });
            menu_salida.Create(new string[] { "Reiniciar", "Salir" }, false);


            _Main(menu, out menu_exe, out option);

            menu_salida.Prints();
            do
            {
                menu_exe = menu_salida.Button(ReadKey().Key.ToString());
            } while (!menu_exe);

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }


            //PUSSSSHHHHH




            ReadKey();
        }

        private static void _Main(Menu menu, out bool menu_exe, out int option)
        {
            do
            {
                menu_exe = menu.Button(ReadKey().Key.ToString());

            } while (!menu_exe);
            CursorVisible = true;
            Clear();
            option = menu.Select();
            switch (option)
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
        }
    }
}
