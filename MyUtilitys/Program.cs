using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace MyUtilitys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Validation val = new Validation();
            val.SetMessage("Digite un");
            do
            {
                a = val.DblData(true,"doble",true,4);

            } while (a != 12345);

            ReadKey();
        }
    }
}
