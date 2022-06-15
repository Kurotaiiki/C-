using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ConSaludo
{
    internal class ConSaludo
    {
        

        static void Main(string[] args)
        {

            PedirDatos(out string nombre, out string apellido, out string direccion, out uint telefono, out int cedula, out string ciudad);
            Clear();
            WriteLine(
                $"Hola los datos ingresados son los siguientes: \n" +
                $"\n" +
                $"Nombre : {nombre} {apellido} \n" +
                $"Direccion : {direccion}\n" +
                $"Telefono : {telefono}\n" +
                $"Cedula : {cedula} \n" +
                $"Ciudad : {ciudad} \n  "
                );



            //Detenemos el programa
            ReadLine();            
        }

        #region PedirDatos
        private static void PedirDatos(out string nombre, out string apellido, out string direccion, out uint telefono, out int cedula, out string ciudad)
        {
            nombre = Validaciones.Validacion(3, 10, "nombre");
            apellido = Validaciones.Validacion(3, 10, "apellido");
            WriteLine("");
            Write("Ingrese su direccion :.");
            direccion = ReadLine();
            telefono = uint.Parse(Validaciones.Validacion(10, 10, "Numero", true));
            cedula = int.Parse(Validaciones.Validacion(8, 10, "Cedula", true));
            ciudad = Validaciones.Validacion(5, 20, "Ciudad");
        }

        #endregion

       

    }
}
