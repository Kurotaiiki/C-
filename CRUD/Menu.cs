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
        private int[] position;

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


        public void Execute_menu(bool clean = true)
        {
            Write("\n\n");
            string button;
            Prints(clean);
            do
            {
                CursorVisible = false;
                button = ReadKey().Key.ToString();
                switch (button)
                {
                    case "DownArrow":
                        Change("Down",clean);
                        break;
                    case "UpArrow":
                        Change("Up",clean);
                        break;
                    case "Enter":
                        SetCursorPosition(0, CursorTop + arr_options.Length+2);
                        menu_exe = true;
                        break;
                    default:
                        Prints(clean);
                        break;
                }


            } while (!menu_exe);
            CursorVisible = true;
            menu_exe=false;
        }



        



        private void Prints(bool clean = true)
        {

            int i = 1;
            if (clean)
            {
                Clear();
            }

            position = new int[] {0,CursorTop};
            SetCursorPosition(0, position[1]);
            WriteLine("Escoja la opcion deseada");
            foreach (string option_txt in arr_options)
            {

                if (i != selector)
                {
                    WriteLine($"{i}.{option_txt}    ");
                }
                else
                {
                    decorator();
                    WriteLine($">{i}.{option_txt}");
                    decorator(false);

                }
                i++;
            }
            if (!clean)
            {
                SetCursorPosition(0, position[1]);
            }

        }

        private void Change(string arrow,bool clean)
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
            Prints(clean);
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
