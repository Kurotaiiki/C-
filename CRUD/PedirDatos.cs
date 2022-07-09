using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CRUD
{
    internal class PedirDatos
    {
        string message = "Ingrese el";

        public void SetMessage(string str)
        {
            message = str;
        }
        public string StrData(bool withName = true, string dataName = "Data name", bool withSize = true, int minSize = 5, int maxSize = 5)
        {
            string str;

            if (withName)
            {
                Write($"{message} {dataName} .:");
                str = ReadLine();
            }
            else
            {
                str = ReadLine();
            }

            while (withSize && !Size(str, minSize, maxSize))
            {
                SizeError(withName, dataName, minSize, maxSize);
                str = ReadLine();
            }
            return str;
        }

        public int IntData(bool withName = true, string dataName = "Data name", bool withSize = false, int minSize = 5, int maxSize = 5)
        {
            bool check = false;
            int num;
            if (withName)
            {
                Write($"{message} {dataName} .:");
            }
            do
            {
                if (!int.TryParse(ReadLine(), out num))
                {
                    TypeError(withName, dataName);
                }

                if (withSize && !Size(num.ToString(), minSize, maxSize))
                {
                    SizeError(withName, dataName, minSize, maxSize);
                }
                else
                {
                    check = true;
                }

            } while (!check);

            return num;
        }
        public double DblData(bool withName = true, string dataName = "Data name", bool withSize = false, int minSize = 5, int maxSize = 5)
        {
            bool check = false;
            double num;
            if (withName)
            {
                Write($"{message} {dataName} .:");
            }
            do
            {
                if (!double.TryParse(ReadLine(), out num))
                {
                    TypeError(withName, dataName);
                }

                if (withSize && !Size(num.ToString(), minSize, maxSize))
                {
                    SizeError(withName, dataName, minSize, maxSize);
                }
                else
                {
                    check = true;
                }

            } while (!check);

            return num;
        }
        public float FloatDate(bool withName = true, string dataName = "Data name", bool withSize = false, int minSize = 5, int maxSize = 5)
        {
            bool check = false;
            float num;
            if (withName)
            {
                Write($"{message} {dataName} .:");
            }
            do
            {
                if (!float.TryParse(ReadLine(), out num))
                {
                    TypeError(withName, dataName);
                }

                if (withSize && !Size(num.ToString(), minSize, maxSize))
                {
                    SizeError(withName, dataName, minSize, maxSize);
                }
                else
                {
                    check = true;
                }

            } while (!check);

            return num;
        }
        //--------------------------------------------------------------------------------------------------------------------------

        #region Internos

        //--------------------------------------------------------------------------------------------------------------------------
        bool Size(string data, int min, int max)
        {
            int size;
            size = data.Length;

            if (size < min || size > max)
            {
                return false;
            }

            return true;
        }

        private void SizeError(bool withName, string dataName, int minSize, int maxSize)
        {
            if (minSize == maxSize)
            {
                Write($"||DATO INVALIDO|| >({maxSize})< dig||");
            }
            else
            {
                Write($"||DATO INVALIDO||MIN ({minSize}) dig|| MAX ({maxSize}) dig||");
            }

            if (withName)
            {
                Write($"{message} {dataName} .:");
            }
            else
            {
                Write("NUEVO DATO .:");
            }
        }
        private void TypeError(bool withName, string dataName)
        {
            WriteLine($"||DATO INVALIDO||TIPO PERMITIDO: #ENTERO||INGRESE UN DATO VALIDO");
            if (withName)
            {
                Write($"{message} {dataName} .:");
            }
            else
            {
                Write("NUEVO DATO .:");
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------

        #endregion Internos

        //--------------------------------------------------------------------------------------------------------------------------
    }
}




