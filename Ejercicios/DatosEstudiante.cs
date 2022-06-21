using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Ejercicios
{
    internal class DatosEstudiante
    {
        public void Datos()
        {
            string nombre = new PedirDato().StringDate("nombre");
            string apellido = new PedirDato().StringDate("apellido");
            string direccion = new PedirDato().StringDate("direccion");
            string ciudad = new PedirDato().StringDate("ciudad");
            int cedula = new PedirDato().IntDate("cedula");
            int edad = new PedirDato().IntDate("edad");
            Clear();
            WriteLine($"Los datos ingresados fueron los siguientes\n\n" +
                $"Nombre: {nombre}\nApellido: {apellido}\nDireccion: {direccion}\nCiudad: {ciudad}\nCedula: {cedula}\nEdad: {edad}");
        } 
    }
}
