using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Calculadora
{
    internal class MenuSalida
    {
        public bool crear(Calcular calc)
        {
            int opcion = 2222;
            do
            {
                if (opcion != 2222)
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
                WriteLine("\n");
                Write(
                                "Ahora puedes:\n" +
                                "1.Reiniciar el programa\n" +
                               $"2.Seguir operando con el valor en memoria ({calc.memoria})\n" +
                               $"3.Salir del programa\n" +
                               $"\n" +
                               $"Opcion:."
                                   );
                int.TryParse(ReadLine(), out opcion);

            } while (opcion < 1 || opcion > 3);

            switch (opcion)
            {
                case 1:
                    return true;
                case 2:
                    calc.save = true;
                    return true;
                case 3:
                    return false;
            }
            return true;


        }
    }
}
