using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Ejercicios
{
    internal class Notas
    {
        public void GiveNotes()
        {
            Write("Cuantas notas desea evaluar .:");
            int times = new PedirDato().IntDate("",false);
            float totalPercent = 100;
            float[] notes = new float[times];
            float[] percent = new float[times];
            float def = 0;

            for (int i = 0; i <= totalPercent ; i++)
            {
                notes[i] = new PedirDato().FloatDate($"Nota {i+1}",true);
                Write("A que porcentaje vale esta nota ");
                percent[i] = new PedirDato().IntDate("", false);
                while (totalPercent - percent[i] < 0)
                {
                    Write($"No se puede evaluar mas del 100% ingrese un porcentaje menor, recuerde que queda un {totalPercent}% .:");
                    percent[i] = new PedirDato().FloatDate("", false);
                }
                totalPercent -= percent[i];
                if (totalPercent==0)
                {
                    WriteLine("SE ALCANZO EL 100%");
                    times = i + 1;
                }

            }

            for (int i = 0; i < times; i++)
            {
                WriteLine($"Nota{i+1}.{notes[i]}->{percent[i]/100}% = {(notes[i] * percent[i])/100}");
                def += (notes[i] * percent[i]) / 100;
            }

            WriteLine($"El {100-(totalPercent/100)}% de la nota  es {def}");
        }
    }
}
