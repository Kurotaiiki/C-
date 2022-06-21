using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class Areas
    {
        Menu menu =new Menu();
        Menu menu_salida =new Menu();
        Menu menu_Diamond = new Menu();
        bool menu_exe=true;
        int option=0;
        double a;
        double b;
        public void Create()
        {
            menu.Create(new string[] { "Triangulo", "Rombo", "Elipse" }, false);
            menu_salida.Create(new string[] { "Reiniciar", "Salir" }, false);
            menu_Diamond.Create(new string[] { "Base y altura", "Lado y angulo" }, false);


            do
            {

                Calculate();
                Write("\n\nCalculo Finalizado, presione cualquier tecla...:");
                ReadKey();


                do
                {
                    Clear();
                    WriteLine("Recuerde que seguimos en el ejercicio de areas");
                    menu_salida.Prints(false);
                    menu_exe = menu_salida.Button(ReadKey().Key.ToString());

                } while (!menu_exe);

                option = menu_salida.Select();

            } while (option != 2);
        }

        private void Calculate()
        {
            do
            {
                menu.Prints();
                menu_exe = menu.Button(ReadKey().Key.ToString());

            } while (!menu_exe);
            CursorVisible = true;
            Clear();
            option = menu.Select();
            switch (option)
            {
                case 1:
                    Triangle();
                    break;
                case 2:
                    Diamond();
                    break;
                case 3:
                    Ellipse();
                    break;
                default:
                    WriteLine("Por defecto");
                    break;
            }
        }

        private void Triangle()
        {
            a = new PedirDato().DoubleDate("Base");
            b = new PedirDato().DoubleDate("Altura");

            WriteLine($"El area del triangulo es {(a*b)/2}");

        }
        private void Diamond()
        {
            do
            {
                Clear();
                Write("Como desea calcular el area del rombo ");
                menu_Diamond.Prints(false);
                menu_exe = menu_Diamond.Button(ReadKey().Key.ToString());

            } while (!menu_exe);
            CursorVisible = true;
            Clear();

            option = menu_Diamond.Select();

            switch (option)
            {
                case 1:
                    a=new PedirDato().DoubleDate("base");
                    b = new PedirDato().DoubleDate("altura");
                    WriteLine($"El area del rombo es de {a*b}");
                    break;
                case 2:
                    a = new PedirDato().DoubleDate("lado");
                    b= new PedirDato().DoubleDate("angulo");
                    WriteLine($"El area del rombo es de {(a * a)*Math.Sin(Math.Atan(b))}");
                    break;
                default:
                    WriteLine("Por defecto");
                    break;
            }

        }

        private void Ellipse()
        {
            a = new PedirDato().DoubleDate("primer semieje");
            b = new PedirDato().DoubleDate("segundo semieje");
            Write($"El area de la elipse es {a*b*Math.PI}");
        }
    }
}
