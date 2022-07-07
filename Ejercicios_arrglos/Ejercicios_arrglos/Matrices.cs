using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ejercicios_arrglos
{
    internal class Matrices
    {
        PedirDatos myImput=new PedirDatos();
        
        public (double[,], double[,]) RestSum()
        {
            double[,] mat1 = new double[0,0];
            double[,] mat2 = new double[0,0];
            return (mat1, mat2);
        }



        public void Mul()
        {
            int col1 = 0, fil1 = 0, col2 = 0, fil2 = 0;
            bool exe = false;
            myImput.SetMessage("Ingrese el numero .:");

            do
            {
                if (exe)
                {
                    Write("||||RECUERDE QUE EL NUMERO DE COLUMNAS ||||\n" +
                          "||||DE LA PRIMERA MATRIZ DEBE SER IGUAL||||\n" +
                          "||||AL NUMERO DE FILAS DE LA SEGUNDA   ||||\n");
                }


                WriteLine("Ingrese el numero de filas de la primera matriz");
                fil1 = myImput.IntData(false);
                WriteLine("Ingrese el numero de columnas de la primera matriz");
                col1 = myImput.IntData(false);


                WriteLine("Ingrese el numero de filas de la segunda matriz");
                fil2 = myImput.IntData(false);
                WriteLine("Ingrese el numero de columnas de la segunda matriz");
                col2 = myImput.IntData(false);

                exe = true;

            } while (col1 != fil2);


            //ASIGNACION DE TAMANIOS -----------------------------------------------------------------------

            double[,] mat1, mat2;
            double[,] res = new double[fil1, fil1];


            // DEFINICION DE MATRICES -------------------------------------------------------------------------

            Clear();
            WriteLine("Matriz 1");

            CreateMatriz(fil1, col1, out mat1);

            Clear();
            WriteLine("Matriz 2");

            CreateMatriz(fil2, col2, out mat2);



            // IMPRESION DE MATRICES ----------------------------------------------------------------------------------

            Clear();
            WriteLine("Matriz 1");
            WriteMatriz(mat1);

            WriteLine("Matriz 2");
            WriteMatriz(mat2);


            //MULTIPLICACION DE MATRICES------------------------------------------------------------------------------------

            

            for (int i = 0; i < col2; i++) // MAXIMO DE LA RESULTANTE
            {
                for (int j = 0; j < fil1; j++) // MAXIMO DE LA RESULTANTE
                {
                    for (int k = 0; k < col1; k++) // IGUALDAD REQUERIDA PARA LA OPERACION DE LAS MATRICES
                    {
                        res[j, i] += mat1[j, k] * mat2[k, i];
                    }
                }
            }

            WriteLine("Matriz Resultante");
            WriteMatriz(res);     
        }



        private static void WriteMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Write($"|{matriz[i, j]}  \t");
                }
                Write("\n");
            }
        }

        private void CreateMatriz(int col, int fil, out double[,] matriz)
        {
            matriz = new double[fil,col];

            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Write($"Coordenada [{i},{j}] ->");
                    matriz[i, j] = myImput.DblData(false);
                }
            }
        }



    }
}
