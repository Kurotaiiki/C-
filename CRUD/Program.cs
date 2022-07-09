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
        static string txt;
        static string cont;
        static int id;
        static int option;
        static PedirDatos myInput = new PedirDatos();



        static void Main(string[] args)
        {

            ora.Close();
            DataTable table =  InitDB();
            Menu menu = new Menu();
            Menu campo = new Menu();
            menu.Create(new string[] { "Modificar","Agregar","Eliminar", "Salir" }, false);
            campo.Create(new string[] { "Nombre", "Contrasenia","id", "volver al menu" }, false);

            do
            {
                Clear();
                PrintDB(ref table);
                menu.Execute_menu(false);
                option = menu.Select();

                switch (option)
                {
                    case 1:
                        ModifyDB(campo, ref table);
                        UpdateDB(ref table);
                        break;
                    case 2:
                        AddDB(ref table);
                        UpdateDB(ref table);
                        break;
                    case 3:
                        DeleteDB(ref table);
                        break;
                    case 4:
                        break;
                }

            } while (option != 4);
        }

        static DataTable InitDB()
        {
            DataTable dt = new DataTable(); 
            ora.Open();
            OracleCommand command = new OracleCommand("seleccionarPersonas", ora);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("registros", OracleType.Cursor).Direction = System.Data.ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            id = dt.Rows.Count;
            ora.Close();

            return dt;
        }
        static void PrintDB(ref DataTable table)
        {
            WriteLine("||ID  \t||NOMBRE  \t||PASSWORD  \t||");
            Write("||//////////////////////////////////////||\n");
            foreach (DataRow row in table.Rows)
            {
                WriteLine($"||{row["id"]}  \t||{row["nombre"]}   \t||{row["contrasenia"]}  \t||");
            }
            Write("||//////////////////////////////////////||\n");
        }

        static void ModifyDB(Menu campo, ref DataTable table)
        {
            bool exe = false;
            int tempID;

            do
            {

                Write("Ingrese el ID del usuario a modificar .:                    ");
                SetCursorPosition(CursorLeft - 20, CursorTop);
                tempID = (myInput.IntData(false));

                foreach (DataRow row in table.Rows)
                {
                    if (row["id"].ToString() == tempID.ToString())
                    {
                        exe = true;
                    }
                }
                if (!exe)
                {
                    Write("ID NO EXISTE");
                    SetCursorPosition(0, CursorTop - 1);
                }

            } while (!exe);


            campo.Execute_menu(false);
            option = campo.Select();

            switch (option)
            {
                case 1:
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["id"].ToString() == tempID.ToString())
                        {
                            row["nombre"] = myInput.StrData(true, "nuevo nombre del usuario .:", true, 6, 30);
                        }
                    }
                    break;
                case 2:
                    foreach (DataRow row in table.Rows)
                    {
                        if (row["id"].ToString() == tempID.ToString())
                        {
                            row["contrasenia"] = myInput.StrData(true, "password del usuario .:", true, 8, 8);
                        }
                    }
                    break;
                case 3:

                    int i = 0;
                    tempID = 0;
                    exe = false;
                    do
                    {

                        Write("Ingrese el nuevo ID.:                    ");
                        SetCursorPosition(CursorLeft - 20, CursorTop);
                        tempID = (myInput.IntData(false));

                        foreach (DataRow row in table.Rows)
                        {
                            if (row["id"].ToString() == id.ToString())
                            {
                                i++;
                            }
                        }
                        if (i>0)
                        {
                            Write("ID YA EXISTE");
                            SetCursorPosition(0, CursorTop - 1);
                            i = 0;
                        }
                        else
                        {
                            exe = true;
                        }

                    } while (!exe);




                    foreach (DataRow row in table.Rows)
                    {
                        if (row["id"].ToString() == id.ToString())
                        {
                            row["id"] = tempID;
                        }
                    }
                    break;
            }
        }

        static void AddDB(ref DataTable table)
        {
            DataRow row=table.NewRow();
            
            row["id"] = ++id;
            row["nombre"] = myInput.StrData(true, "nombre del usuario", true, 5, 20);
            row["contrasenia"] = myInput.StrData(true, "password del usuario .:", true, 8, 8);
            table.Rows.Add(row);

            ora.Open();
            OracleCommand command = new OracleCommand("insertar", ora);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("nom", OracleType.VarChar).Value = row["nombre"];
            command.Parameters.Add("cont", OracleType.VarChar).Value = row["contrasenia"];
            command.ExecuteNonQuery();

            ora.Close();


        }

        static void DeleteDB(ref DataTable table)
        {
            bool exe= false;
            int tempID;

            do {

                Write("Ingrese el ID del usuario a eliminar .:                    ");
                SetCursorPosition(CursorLeft - 20, CursorTop);
                tempID = (myInput.IntData(false));

                foreach (DataRow row in table.Rows)
                {
                    if (row["id"].ToString() == tempID.ToString())
                    {
                        exe = true;
                    }
                }
                if(!exe)
                {
                    Write("ID NO EXISTE");
                    SetCursorPosition(0, CursorTop - 1);
                }

            }while (!exe);

            
            ora.Open();
            OracleCommand command = new OracleCommand("eliminar", ora);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("idp", OracleType.Number).Value = tempID;
            command.ExecuteNonQuery();

            ora.Close();
            UpdateDB(ref table);
        }



        static void UpdateDB(ref DataTable table)
        {
            ora.Open();
            foreach (DataRow row in table.Rows)
            {
                OracleCommand command = new OracleCommand("actualizar", ora);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idp", OracleType.Number).Value = row["id"];
                command.Parameters.Add("nom", OracleType.VarChar).Value = row["nombre"];
                command.Parameters.Add("cont", OracleType.VarChar).Value = row["contrasenia"];
                command.ExecuteNonQuery();               
            }
            ora.Close();
        }
    }
}
