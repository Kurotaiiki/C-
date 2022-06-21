using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Ejercicios
{
    internal class Menu
    {
        private int selector = 1;
        private int restart = 1;
        private string[] arr_options;



        public void Create(Array options, bool print = true)
        {
            List<string> list_opciones = new List<string>();
            foreach (string op in options)
            {
                list_opciones.Add(op);
            }
            arr_options = list_opciones.ToArray();
            restart = arr_options.Length;
            if (print)
            {
                Prints();
            }

        }

        //Pushhhhhh

        public void Prints(bool Clean=true)
        {

            int i = 1;
            if (Clean)
            {
                Clear();
            }            
            WriteLine("Escoja la opcion deseada");

            foreach (string option_txt in arr_options)
            {

                if (i != selector)
                {
                    WriteLine($"{i}.{option_txt}");
                }
                else
                {
                    decorator();
                    WriteLine($">{i}.{option_txt}");
                    decorator(false);

                }
                i++;
            }
        }




        public void Change(string arrow)
        {
            if (arrow == "Down")
            {
                selector++;
            }
            else if (arrow == "Up")
            {
                selector--;
            }


            if (selector > restart)
            {
                selector = 1;
            }
            else if (selector < 1)
            {
                selector = restart;
            }
            Prints();
        }



        public int Select()
        {
            return selector;
        }


        public bool Button(string button)
        {
            switch (button)
            {
                case "DownArrow":
                    Change("Down");
                    return false;
                case "UpArrow":
                    Change("Up");
                    return false;
                case "Enter":
                    return true;
                default:
                    return false;

            }
        }

        void decorator(bool open = true)
        {
            if (open)
            {
                BackgroundColor = ConsoleColor.White;
                ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
            }


        }


    }
}
