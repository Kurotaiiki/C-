using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Pruebas
{
    internal class ClassSuma
    {   //Metodo para sumar los dos numeros
        public double SumarNumeros(double num1, double num2)
        {
            return num1 + num2;
        }

        //Metodo para restar los dos numeros
        public double RestarNumeros(double num1, double num2)
        {
            return num1 - num2;
        }
        //metodo para multiplicar numeros
        public double MultiplicarNumeros(double num1, double num2)
        {
            return num1 * num2;
        }
        //metodo para dividir numeros
        public double DividirNumeros(double num1, double num2)
        {
            return num1 / num2;
        }

        public void MostrarResultado(double res)
        {
            WriteLine($"el resultado de su operacion es: {res}\n");
        }



    }
}