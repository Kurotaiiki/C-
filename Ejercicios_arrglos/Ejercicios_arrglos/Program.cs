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
            menu.Create(new string[] { "Tablas de multiplicar", "Operaciones basicas", "Nomina" ,"Operacion de matrices", "Salir" },false);
            int option;

            do
            {


                menu.Execute_menu(false);
                option = menu.Select();

                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        Write("Cuantos numeros se van a operar");
                        new OperacionesBasicas().Operar(myInput.IntData(false));
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        new Matrices().Mul();
                        break;
                    default:
                        break;
                }


            } while (option != 3);



        }
    }
}
