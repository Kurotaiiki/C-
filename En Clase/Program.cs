using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace En_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Menu menu_salida = new Menu();
            bool menu_exe = true;
            int option;
            menu.Create(new string[] { "Multiplos de 5", "Pares", "Primos", "d" });
            menu_salida.Create(new string[] { "Reiniciar", "Salir" });

            do
            {
                _main(menu, out menu_exe, out option);
                Write("\nEjercicio terminado, pulse una tecla para continuar.....");
                ReadKey();

                do
                {
                    menu_salida.Prints();
                    menu_exe = menu_salida.Button(ReadKey().Key.ToString());

                } while (!menu_exe);

                option = menu_salida.Select();

            } while (option!=2);


        }

        private static void _main(Menu menu, out bool menu_exe, out int option)
        {
            do
            {
                menu.Prints();
                menu_exe = menu.Button(ReadKey().Key.ToString());

            } while (!menu_exe);

            option = menu.Select();
            Clear();
            switch (option)
            {
                case 1:
                    Multiples(5);
                    break;
                case 2:
                    Multiples(2);
                    break;
                case 3:
                    Write("Ingrese el numero a evaluar .:");
                    Primes(new PedirDato().IntDate("",false));
                    break;
                default:
                    break;
            }
        }


        // esta funcion evalua los numeros divisibles por la variable "a" hasta el numero "times"
        static void Multiples(int a)
        {
            Clear();
            Write("Ingrese hasta que numero quiere mostrar los multiplos de 5 .:");
            int times =new PedirDato().IntDate("",false); // "new PedirDato().IntDate("",false);" se puede reemplazar por un int.Parse(ReadLine()) para pedirle el dato al usuario
            int num = a;
            for (int i = num; i <= times; i+=num)
            {
                Write($"|{i}");
                
            }
        }

        
        //esta funcion evalua si "a" es un numero primo
        static void Primes(int a)
        {
            int times=0;

            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    times++;
                }
            }
            if (times==2)
            {
                Write($"{a} Es un numero primo");
            }
            else
            {
                Write($"{a} No es un numero primo");
            }

        }
    }
}
