using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using static System.Console;
using System.Data;

namespace CRUD
{
    internal class Program
    {
        static OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=123;USER ID=pruebaUsuario;");
        static DataTable table = new DataTable();
        static string txt;
        static string cont;
        static int id;
        static int option;
        static PedirDatos myInput = new PedirDatos();



        static void Main(string[] args)
        {

            ora.Close();
            InitDB();



            Menu menu = new Menu();
            Menu campo = new Menu();
            menu.Create(new string[] { "Modificar", "Salir" }, false);
            campo.Create(new string[] { "Nombre", "Contrasenia", "volver al menu" }, false);

            do
            {
                Clear();
                PrintDB();
                menu.Execute_menu(false);
                option = menu.Select();

                switch (option)
                {
                    case 1:
                        ModifyDB(campo);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        break;
                }

            } while (option != 4);
            ReadKey();
        }

        static DataTable InitDB()
        {
            ora.Open();
            OracleCommand command = new OracleCommand("seleccionarPersonas", ora);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("registros", OracleType.Cursor).Direction = System.Data.ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            id = table.Rows.Count;
            ora.Close();

            return table;
        }
        static void PrintDB()
        {
            foreach (DataRow row in table.Rows)
            {
                WriteLine($"||{row["id"]}  \t|{row["nombre"]}   \t|{row["contrasenia"]}  \t||");
            }
        }

        static void ModifyDB(Menu campo)
        {
            do
            {
                Write("Ingrese el ID del usuario a modificar .:                    ");
                SetCursorPosition(CursorLeft - 20, CursorTop);
                id = (myInput.IntData(false)) - 1;

                if (id < 0 || id >= table.Rows.Count)
                {
                    Write("ID FUERA DE RANGO");
                    SetCursorPosition(0, CursorTop - 1);
                }

            } while (id < 0 || id >= table.Rows.Count);


            campo.Execute_menu(false);
            option = campo.Select();

            switch (option)
            {
                case 1:
                    table.Rows[id]["nombre"] = myInput.StrData(true, "nombre del usuario", true, 6, 20);
                    break;
                case 2:
                    table.Rows[id]["contrasenia"] = myInput.IntData(true, "password del usuario .:", true, 8, 8);
                    break;
                default:
                    break;
            }
        }


        //static void Connect(bool on=true)
        //{

        //    if (on)
        //    {
        //        ora.Open();
        //        WriteLine("conectado");
        //    }
        //    else
        //    {
        //        ora.Close();
        //        WriteLine("desconectado");
        //    }
        //}

        //static void WriteDB()
        //{
        //    try
        //    {
        //        Connect();
        //        OracleCommand command = new OracleCommand("insertar", ora);
        //        command.CommandType = System.Data.CommandType.StoredProcedure;
        //        Write("Ingrese el nombre que desea agregar .:");
        //        txt = ReadLine();
        //        command.Parameters.Add("nom", OracleType.VarChar).Value = txt;
        //        Write("Cree la contrasena.:");
        //        cont = ReadLine();
        //        command.Parameters.Add("cont", OracleType.VarChar).Value = cont;
        //        command.ExecuteNonQuery();
        //        Write("Persona insertada");
        //        UpdateDB();

        //    }
        //    catch (Exception)
        //    {
        //        Write("NO SE PUDO INSERTAR");
        //    }

        //    Connect(false);

        //}

        static void UpdateDB(bool mod = false)
        {
            ora.Open();
            foreach (DataRow row in table.Rows)
            {
                OracleCommand command = new OracleCommand("actualizar", ora);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idp", OracleType.Number).Value = row["id"];
                command.Parameters.Add("nom", OracleType.VarChar).Value = txt;
                command.Parameters.Add("cont", OracleType.VarChar).Value = cont;
                command.ExecuteNonQuery();
                Write("actualizada");
                ora.Close();
            }

        }
    }
}
