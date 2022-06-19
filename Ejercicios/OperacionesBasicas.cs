using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class OperacionesBasicas
    {
        public double Suma(bool Ingresar=false,double a=0,double b=0)
        {
            if (Ingresar)
            {
                return a + b;
            }

            return new PedirDato().Doble("numero 1") + new PedirDato().Doble("numero 2");
        }

        public double Resta(bool Ingresar = false, double a = 0, double b = 0)
        {
            if (Ingresar)
            {
                return a - b;
            }
            return new PedirDato().Doble("numero 1") + new PedirDato().Doble("numero 2");
        }
        public double Multiplicacion(bool Ingresar = false, double a = 0, double b = 0)
        {
            if (Ingresar)
            {
                return a * b;
            }
            return new PedirDato().Doble("numero 1") + new PedirDato().Doble("numero 2");
        }
        public double Division(bool Ingresar = false, double a = 0, double b = 0)
        {
            if (Ingresar)
            {

                return a/ b;
            }

            a = new PedirDato().Doble("numero 1");

            while(new PedirDato().Doble("numero 2") == 0)
            {
                WriteLine("Recuerde que no es posible dividir entre 0");
            }

            return new PedirDato().Doble("numero 1") + new PedirDato().Doble("numero 2");
        }

        public void MostrarTodas()
        {
            double a = new PedirDato().Doble("numero 1");
            double b = new PedirDato().Doble("numero 2");

            WriteLine($"{a}+{b} = { Suma(true, a, b)}" );
            WriteLine($"{a}-{b} = { Resta(true, a, b)}" );
            WriteLine($"{a}x{b} = { Multiplicacion(true, a, b)}" );

            if (b == 0)
            {
                WriteLine($"{a}/{b} = Syntaxis Error");
            }
            else
            {
                WriteLine($"{a}/{b} = {Suma(true, a, b)}");
            }


        }


    }
}
