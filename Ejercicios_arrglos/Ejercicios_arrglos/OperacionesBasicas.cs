using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ejercicios_arrglos
{
    internal class OperacionesBasicas
    {
        PedirDatos myInput = new PedirDatos();
        public void Operar(int nums)
        {
            myInput.SetMessage("Ingrese el numero");
            double[] num1 = new double[nums];
            double[] num2 = new double[nums];

            Write("Arreglo 1\n");
            for (int i = 0; i < nums; i++)
            {
                num1[i] = myInput.DblData(true,(i+1).ToString());
            }
            Write("\nArreglo 2\n");
            for (int i = 0; i < nums; i++)
            {
                num2[i] = myInput.DblData(true, (i + 1).ToString());
            }

            Operaciones(num1 , num2);

        }

        static void Operaciones(double[] nums1, double[] nums2)
        {
            double[] suma = new double[nums1.Length];
            double[] resta = new double[nums1.Length];
            double[] mul = new double[nums1.Length];
            double[] div = new double[nums1.Length];


            for (int i = 0; i < nums1.Length; i++)
            {
                suma[i] = nums1[i] + nums2[i];
                resta[i] = nums1[i] - nums2[i];
                mul[i] = nums1[i] * nums2[i];
                div[i] = nums1[i] * nums2[i];
            }


            Write("\n\nSuma//////////////////////////////////////////////////////");
            Arrs(nums1, nums2);
            Write("\nTotal  \t\t");
            MyPrint(suma);


            
            Write("\n\nResta/////////////////////////////////////////////////////");
            Arrs(nums1, nums2);
            Write("\nResta  \t\t");
            MyPrint(resta);


            Write("\n\nMultiplicacion////////////////////////////////////////////");
            Arrs(nums1, nums2);
            Write("\nTotal  \t\t");
            MyPrint(mul);


            Write("\n\nDivision//////////////////////////////////////////////////");
            Arrs(nums1, nums2);
            Write("\nTotal  \t\t");
            MyPrint(div);


        }

        private static void Arrs(double[] nums1, double[] nums2)
        {
            for (int i = 0; i < 2; i++)
            {
                Write($"\nArreglo {i + 1}   \t");
                if (i == 0)
                {
                    MyPrint(nums1);

                }
                else
                {
                    MyPrint(nums2);
                }
            }
        }

        static void MyPrint(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Write($"|{arr[i]}  \t");
            }
        }
    }
}
