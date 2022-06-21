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
            menu.Create(new string[] { "Saludo", "Datos del estudiante", "Suma", "Operaciones basicas", "Comparar", "Calculos", "Cuadratica", "Areas", "Salario", "Mayor de edad"});
            menu_salida.Create(new string[] { "Reiniciar", "Salir" }, false);

            do
            {

                _Main(menu, out menu_exe, out option);
                Write("\n\nEjercicio Finalizado, presione cualquier tecla...:");
                ReadKey();
                do
                {


                    menu_salida.Prints();
                    menu_exe = menu_salida.Button(ReadKey().Key.ToString());
                    



                } while (!menu_exe);

                option = menu_salida.Select();

            }while (option!=2);
        }

        private static void _Main(Menu menu, out bool menu_exe, out int option)
        {
            do
            {
                menu.Prints();
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
                    Write($"La suma da {new OperacionesBasicas().Suma(true, new PedirDato().DoubleDate("Numero 1"), new PedirDato().DoubleDate("Numero 2"))}");
                    break;

                case 4:
                    new OperacionesBasicas().MostrarTodas();
                    break;

                case 5:
                    new CompararNumeros().Comparar();
                    break;

                case 6:
                    new Notas().GiveNotes();
                    break;

                case 7:
                    new Cuadratica().Calculate();
                    break;

                case 8:
                    new Areas().Create();
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
