using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ConSaludo
{
    public class Validaciones
    {    

        #region Validacion
        public static string Validacion(int minDigitos, int maxDigitos, string id = null, bool numeros = false)
        {
            int alfabetico;
            bool validar = false;
            uint numerico;
            if (id != null)
            {
                WriteLine("");
                Write($"Ingrese su {id} :..");
            }
            string n = ReadLine();

            while (n.Length < minDigitos || n.Length > maxDigitos)
            {
                Clear();
                Beep();
                if (minDigitos == maxDigitos)
                {
                    WriteLine("");
                    WriteLine($"El dato ingresado debe ser de {maxDigitos} digitos");
                }
                else
                {
                    WriteLine("");
                    WriteLine($"El dato ingresado debe ser de minimo {minDigitos} y maximo {maxDigitos} digitos");
                }

                if (id != null)
                {
                    WriteLine("");
                    Write($"Repita su {id} :..");
                    n = ReadLine();
                }
                else
                {
                    WriteLine("");
                    Write($"Ingrese el dato nuevamente:..");
                    n = ReadLine();
                }

            }

            do
            {
                alfabetico = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    char c = n[i];
                    if (!char.IsLetter(c))
                    {
                        alfabetico++;
                    }
                }

                if (numeros)
                {
                    if (!uint.TryParse(n, out numerico))
                    {
                        Clear();
                        Beep();
                        WriteLine("!!!!Solo puede contener numeros!!!! ");
                        if (id != null)
                        {
                            WriteLine("");
                            Write($"Repita su {id} :..");
                        }
                        n = ReadLine();
                    }
                    else
                    {
                        validar = true;
                    }
                }
                else
                {
                    if (alfabetico > 0)
                    {
                        Clear();
                        Beep();
                        WriteLine("!!!!No puede contener caracteres especiales o numeros!!!! ");
                        if (id != null)
                        {
                            WriteLine("");
                            Write($"Repita su {id} :..");
                        }

                        n = ReadLine();
                    }
                    else
                    {
                        validar = true;
                    }
                }

            } while (!validar);

            return n;

        }
        #endregion 
    }

}
