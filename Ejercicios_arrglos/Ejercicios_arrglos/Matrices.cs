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
        int col1 = 0, fil1 = 0, col2 = 0, fil2 = 0;
        double[,] mat1, mat2;
        double[,] res;
        bool exe = false;



        public double[,] Rest()
        {

            CreateTwoMatriz("||||RECUERDE QUE EL NUMERO DE COLUMNAS ||||\n" +
                          "||||DE LA PRIMERA MATRIZ DEBE SER IGUAL||||\n" +
                          "||||AL NUMERO DE COLUMNAS DE LA SEGUNDA||||\n" +
                          "||||DEL MISMO MODO CON LAS FILAS       ||||\n",true);

            Clear();
            WriteLine("Matriz 1");
            WriteMatriz(mat1);

            WriteLine("Matriz 2");
            WriteMatriz(mat2);

            for (int i = 0; i < col1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    res[i,j] = mat1[i,j] - mat2[i,j];
                }
            }

            WriteLine("Matriz Resultante");
            WriteMatriz(res);


            return res;
        }

        public double[,] Sum()
        {

            CreateTwoMatriz("||||RECUERDE QUE EL NUMERO DE COLUMNAS ||||\n" +
                          "||||DE LA PRIMERA MATRIZ DEBE SER IGUAL||||\n" +
                          "||||AL NUMERO DE COLUMNAS DE LA SEGUNDA||||\n" +
                          "||||DEL MISMO MODO CON LAS FILAS       ||||\n", true);

            Clear();
            WriteLine("Matriz 1");
            WriteMatriz(mat1);

            WriteLine("Matriz 2");
            WriteMatriz(mat2);

            res = new double[fil1, col1];

            for (int i = 0; i < fil1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    res[i,j] = mat1[i,j] + mat2[i,j];
                }
            }

            WriteLine("Matriz Resultante");
            WriteMatriz(res);
            ReadKey();

            return res;
        }

        public void Mul()
        {
            CreateTwoMatriz("||||RECUERDE QUE EL NUMERO DE COLUMNAS ||||\n" +
                          "||||DE LA PRIMERA MATRIZ DEBE SER IGUAL||||\n" +
                          "||||AL NUMERO DE FILAS DE LA SEGUNDA   ||||\n", false);



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
                        res[j,i] += mat1[j , k] * mat2[k,i];
                    }
                }
            }

            WriteLine("Matriz Resultante");
            WriteMatriz(res);
            ReadKey();
        }

        private void CreateTwoMatriz(string message,bool suma)
        {
            myImput.SetMessage("Ingrese el numero .:");
            bool condicion;

            do
            {
                if (exe)
                {
                    Write(message);
                }

                DefinirDimensiones(out col1, out fil1, out col2, out fil2);

                exe = true;

                if (suma)
                {
                    condicion = col1 != col2 || fil1 != fil2;
                }
                else
                {
                    condicion = col1 != fil2;
                }

            } while (condicion);


            //ASIGNACION DE TAMANIOS -----------------------------------------------------------------------

            res = new double[fil1, fil1];


            // DEFINICION DE MATRICES -------------------------------------------------------------------------

            Clear();
            WriteLine("Matriz 1");

            CreateMatriz(fil1, col1, out mat1);

            Clear();
            WriteLine("Matriz 2");

            CreateMatriz(fil2, col2, out mat2);
        }

        private void DefinirDimensiones(out int col1, out int fil1, out int col2, out int fil2)
        {
            WriteLine("Ingrese el numero de filas de la primera matriz");
            fil1 = myImput.IntData(false);
            WriteLine("Ingrese el numero de columnas de la primera matriz");
            col1 = myImput.IntData(false);


            WriteLine("Ingrese el numero de filas de la segunda matriz");
            fil2 = myImput.IntData(false);
            WriteLine("Ingrese el numero de columnas de la segunda matriz");
            col2 = myImput.IntData(false);
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

        private void CreateMatriz(int fil, int col, out double[,] matriz)
        {
            matriz = new double[fil,col];

            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Write($"Coordenada [{i},{j}] ->");
                    matriz[i,j] = myImput.DblData(false);
                }
            }
        }



    }
}
