using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CRUD
{
    internal class Menu
    {
        private int selector = 1;
        private int restart = 1;
        private bool menu_exe = false;
        private string[] arr_options;

        public void Create(Array options, bool print = true)
        {
            List<string> list_options = new List<string>();


            foreach (string op in options)
            {
                list_options.Add(op);
            }
            arr_options = list_options.ToArray();
            restart = arr_options.Length;
            if (print)
            {
                Prints();
            }

        }

        public int Select()
        {
            return selector;
        }


        public void Button()
        {
            string button;
            Prints();
            do
            {
                button = ReadKey().Key.ToString();
                switch (button)
                {
                    case "DownArrow":
                        Change("Down");
                        break;
                    case "UpArrow":
                        Change("Up");
                        break;
                    case "Enter":
                        
                        menu_exe = true;
                        break;
                }

            } while (!menu_exe);
            menu_exe=false;
        }







        private void Prints(bool Clean = true)
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

        private void Change(string arrow)
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

        private void decorator(bool open = true)
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
