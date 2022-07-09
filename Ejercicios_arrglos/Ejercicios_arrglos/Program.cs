using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ejercicios_arrglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedirDatos myInput = new PedirDatos();
            Menu menu = new Menu();
            Menu op = new Menu();
            menu.Create(new string[] { "Tablas de multiplicar", "Operaciones basicas", "Nomina" ,"Operacion de matrices", "Salir" },false);
            op.Create(new string[] { "Suma", "Resta", "Multiplicacion" , "Salir" },false);
            int option;

            do
            {


                menu.Execute_menu(false);
                option = menu.Select();

                switch (option)
                {
                    case 1:
                        new Tablas().Operar();
                        break;
                    case 2:
                        Write("Cuantos numeros se van a operar");
                        new OperacionesBasicas().Operar(myInput.IntData(false));
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        do
                        {
                            op.Execute_menu();
                            option = op.Select();
                            switch (option)
                            {
                                case 1:
                                    new Matrices().Sum();
                                    break;
                                case 2:
                                    new Matrices().Rest();
                                    break;
                                case 3:
                                    new Matrices().Mul();
                                    break;
                            }
                        } while (option != 4);
                        option = 0;
                        break;
                    default:
                        break;
                }

                WriteLine("\nPulse una tecla para continuar . . .");
                ReadKey();
                Clear();

            } while (option != 3);



        }
    }
}
