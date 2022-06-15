using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

            ReadKey();

        }

        static void Menu()
        {
            double opcion = 2222;
            do
            {
                if (opcion != 2222)
                {
                    WriteLine("");
                    Write("Recuerde mirar las opciones disponibles");
                }
                WriteLine(
                    "|-/////////////////////////////|--|\n" +
                    "|----------Calculadora------------|\n" +
                    "|--/////////////////////////////--|\n" +
                    "|--Que operacion desea realizar---|\n" +
                    "|--/////////////////////////////--|\n" +
                    "|--/////////////////////////////--|\n" +
                    "|--1.Suma-------------------------|\n" +
                    "|--2.Resta------------------------|\n" +
                    "|--3.Multiplicacion---------------|\n" +
                    "|--4.Division---------------------|\n" +
                    "|--/////////////////////////////--|"
                    );
                opcion = Calcular.Validar();

            } while (opcion < 0 && opcion > 5);
        }
    }
}
