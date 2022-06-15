using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class Menu
    {
        public void Crear(Calcular calculadora)
        {

            int opcion = 22922;

            do
            {
                Clear();
                if (opcion != 22922)
                {
                    WriteLine("");
                    WriteLine(
                        "|||||||||||||||||||||||||||||||||||||||\n" +
                        "|||||||||||||||||||||||||||||||||||||||\n" +
                        "Recuerde mirar las opciones disponibles\n" +
                        "|||||||||||||||||||||||||||||||||||||||\n" +
                        "|||||||||||||||||||||||||||||||||||||||\n"
                        );
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
                    "|--5.Potencia---------------------|\n" +
                    "|--/////////////////////////////--|\n"
                    );
                if (calculadora.save)
                {
                    WriteLine($"\n\n|||Numero en memoria:{calculadora.memoria}|||\n\n");
                }
                Write("||Opcion||:.");
                int.TryParse(ReadLine(), out opcion);


            } while (opcion < 1 || opcion > 5);

            switch (opcion)
            {
                case 1:
                    Clear();
                    WriteLine("Ingresa los numeros a Sumar");
                    calculadora.memoria = calculadora.Sumar();
                    return;
                case 2:
                    Clear();
                    WriteLine("Ingresa los numeros a Restar");
                    calculadora.memoria = calculadora.Resta();
                    return;
                case 3:
                    Clear();
                    WriteLine("Ingresa los numeros a Multiplicar");
                    calculadora.memoria = calculadora.Multiplicar();
                    return;
                case 4:
                    Clear();
                    WriteLine("Ingresa los numeros a Dividir");
                    calculadora.memoria = calculadora.Division();
                    return;
                case 5:
                    Clear();
                    WriteLine("Ingresa la base y el exponente");
                    calculadora.memoria = calculadora.Potenciar();
                    return;

            }



        }
    }
}
