using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using static System.Console;

namespace CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Menu menu = new Menu();
            menu.Create(new string[]{"Conectar","Desconectar","Salir"},false);

            do
            {

                menu.Button();
                option = menu.Select();

                switch (option)
                {
                    case 1:
                        Connect(true);
                        ReadKey();
                        break;
                    case 2:
                        Connect(false);
                        ReadKey();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }

            } while ( option != 3 );
        }

        static void Connect(bool on)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=123;USER ID=pruebaUsuario;");

            if (on)
            {
                ora.Open();
                WriteLine("conectado");
            }
            else
            {
                ora.Close();
                WriteLine("desconectado");
            }
        }
    }
}
