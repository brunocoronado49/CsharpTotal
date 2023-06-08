using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Variables
    {
        public static void IntroVariables()
        {
            int num1 = 30;
            int num2 = 10;
            int suma = num1 + num2;
            Console.WriteLine($"La suma de {num1} con {num2} da como resultado {suma}");

            double d1 = 3.5;
            double d2 = 1.334;
            double sumad = d1 + d2;
            Console.WriteLine($"La suma de {d1} con {d2} da como resultado {sumad}");
        }

        public static void VariablesTexto()
        {
            string nombre = "Francisco";
            Console.WriteLine($"Hola mi nombre es {nombre}");

            string nombreMayuscula = nombre.ToUpper();
            Console.WriteLine(nombreMayuscula);

            string nombreMinuscula = nombre.ToLower();
            Console.WriteLine(nombreMinuscula);

            bool contiene = nombre.Contains("F");
            Console.WriteLine(contiene);
        }

        public static void Convenciones()
        {
            Console.Write("Ingresa tu nombre: ");
            string? nombre = Console.ReadLine();
            Console.WriteLine(nombre);

            Console.Write("Ingresa un valor: ");
            int valorASCII = Console.Read();
            Console.WriteLine(valorASCII);

        }

        public static void CambioColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I am Batman");
        }

        public static void Conversiones()
        {
            int myInteger = 20;
            double myDouble = 23.21;

            double myIntToDouble = Convert.ToDouble(myInteger);
            int myDoubleToInt = Convert.ToInt32(myDouble);
            string myIntToString = Convert.ToString(myInteger);

            Console.WriteLine(myIntToDouble);
            Console.WriteLine(myDoubleToInt);
            Console.WriteLine(myIntToString);
            Console.WriteLine(myDouble.ToString());

            string myString = "40";
            string myOtherString = "12";

            int myStringToInt = Int32.Parse(myString);
            int myOtherStringToInt = Int32.Parse(myOtherString);

            Console.WriteLine(myStringToInt + myOtherStringToInt);
        }
    }
}
