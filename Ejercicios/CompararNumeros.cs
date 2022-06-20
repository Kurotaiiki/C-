using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class CompararNumeros
    {
        static double[] arr_Numbers;
        double minor, major,medium;
        public void Comparar()
        {
            Write("cunatos numeros desea comparar :.");
            Generate(new PedirDato().Entero("", false));

        }


        ///--------------------------------------------------//
        
        
        
        
        private void Generate(int veces)
        {
            arr_Numbers = new double[veces];
            for (int i = 0; i < veces; i++)
            {
                arr_Numbers[i] = new PedirDato().Doble($"numero {i + 1}");
            }
            major = MajorAndMinor(arr_Numbers, true);
            minor = MajorAndMinor(arr_Numbers, false);
            Prints(major, minor);
            WriteLine("\n\nAscendente");
            Order(arr_Numbers,true);
            WriteLine("\n\nDescendente");
            Order(arr_Numbers, false );
            ReadKey();
        }

        private void Order(double[] _arr_numbers,bool _major)
        {
            List<double> order = new List<double>();
            List<double> clone = arr_Numbers.ToList<double>();
            if (_major)
            {
                for (int i = 0; i < arr_Numbers.Length; i++)
                {
                    double[] j = clone.ToArray();
                    order.Add(MajorAndMinor(j, false));
                    clone.Remove(MajorAndMinor(j, false));

                }
            }
            else
            {
                for (int i = 0; i < arr_Numbers.Length; i++)
                {
                    double[] j = clone.ToArray();
                    order.Add(MajorAndMinor(j,true));
                    clone.Remove(MajorAndMinor(j, true));

                }
            }

            for (int i = 0; i < clone.Count; i++)
            {
                Write($"|{clone[i]}");
            }







            




        }

        private void Prints(double _major,double _minor)
        {
            
            Console.WriteLine($"El numero mayor es {_major} y el menor es {_minor}");
        }

        private static double MajorAndMinor(double[] _arr_Numbers,bool bool_major)
        {
            double _minor, _major;
            _major = _arr_Numbers[0];
            _minor = _arr_Numbers[0];
            foreach (double number in _arr_Numbers)
            {
                if (number < _minor)
                {
                    _minor = number;
                }
                if (number > _major)
                {
                    _major = number;
                }
            }
            if (bool_major)
            {
                return _major;
            }
            return _minor;

        }
    }
}
