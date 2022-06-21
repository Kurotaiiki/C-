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
        double minor, major;
        public void Comparar()
        {
            Write("cunatos numeros desea comparar :.");
            Generate(new PedirDato().IntDate("", false));

        }


        ///--------------------------------------------------//
        
        
        
        
        private void Generate(int veces)
        {
            arr_Numbers = new double[veces];
            for (int i = 0; i < veces; i++)
            {
                arr_Numbers[i] = new PedirDato().DoubleDate($"numero {i + 1}");
            }
            major = MajorAndMinor(arr_Numbers, true);
            minor = MajorAndMinor(arr_Numbers, false);
            arr_Numbers = Order(arr_Numbers, true);
            if (veces%2==0)
            {
                Solution(major, minor, arr_Numbers[(veces/2)-1], arr_Numbers[(veces / 2)],true);
            }
            else
            {
                Solution(major, minor, arr_Numbers[(veces / 2)], arr_Numbers[(veces / 2)], false);
            }
            WriteLine("\n\nAscendente");
            Prints(arr_Numbers);
            WriteLine("\n\nDescendente");
            Prints(Order(arr_Numbers, false));
        }

        private double[] Order(double[] _arr_numbers,bool _major)
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

            return order.ToArray<double>();

        }

        private void Solution(double _major,double _minor,double _mid=0,double _mid2=0,bool par=true)
        {
            if (par)
            {
                Console.WriteLine($"\nEl numero mayor es {_major}, el menor es {_minor} y los medios al ser un numero par de elementos son {_mid}<->{_mid2}." +
                                  $"\nLa diferencia entre el mayor y menor es {_major - _minor} ");
            }
            else
            {
                Console.WriteLine($"\nEl numero mayor es {_major}, el menor es {_minor} y el medio es {_mid}." +
                $"\nLa diferencia entre el mayor y el menor es {_major - _minor} ");
            }
            
        }

        private void Prints(double[] arr_numbers)
        {
            foreach (double item in arr_numbers)
            {
                Write($"|{item}");
            }
            Write("|");
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
