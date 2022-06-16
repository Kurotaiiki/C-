using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Comparar_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparar comparador= new Comparar();;
            int actual;
            int repeticiones=2;
            WriteLine("Cuantos numeros desea comparar ?");
            Write("-->>");
            

            while(!int.TryParse(ReadLine(),out repeticiones))
            {
                Clear();
                WriteLine("Recuerde debe ingresar un numero y que sea mayor que 1\n");
                WriteLine("Cuantos numeros desea comparar ?");
                Write("-->>");               
            }

            WriteLine(repeticiones);



            for (int i = 0; i < repeticiones; i++)
            {
                Clear();
                WriteLine($"Ingrese el numero {i + 1}");
                while (!int.TryParse(ReadLine(), out actual))
                {
                    Clear();
                    WriteLine("Recuerde debe ingresar un numero\n");
                    WriteLine($"Ingrese el numero {i + 1}");
                    Write("-->>");
                    
                }
                comparador.Compare(actual);
            }

            comparador.MostrarMayor();

            ReadKey();
        }
    }
}
