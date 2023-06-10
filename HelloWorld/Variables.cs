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

        public static void FormateoString()
        {
            string? videojuego;

            Console.Write("Tu videojuego favorito: ");
            videojuego = Console.ReadLine();

            Console.WriteLine(videojuego?.ToUpper());
            Console.WriteLine(videojuego?.ToLower());
            Console.WriteLine(videojuego?.Trim());

            int substring;
            Console.Write("Ingresa un nunmero para sacar el substring");

            substring = Int32.Parse(Console.ReadLine());
            Console.WriteLine(videojuego?.Substring(substring));
        }

        public static void FindLetra()
        {
            string? palabra;
            char letra;

            Console.Write("Inrgesa una palabra: ");
            palabra = Console.ReadLine();

            Console.Write("Inrgesa una letra a encontrar: ");
            letra = Convert.ToChar(Console.ReadLine());

            bool letraEnPalabra = palabra.Contains(letra);

            Console.WriteLine($"La letra esta en la palabra? {letraEnPalabra}");
            Console.WriteLine($"Indice desde la primer letra: {palabra.IndexOf(letra)}");
            Console.WriteLine(palabra.Substring(palabra.IndexOf(letra)));
        }

        public static void Constantes()
        {
            const string nombre = "Francisco";
            const double PI = 3.141592;
            const int meses = 12, dias = 365;

            Console.WriteLine(nombre);
            Console.WriteLine(PI);
            Console.WriteLine($"Meses: {meses}, Dias: {dias}");

            string numero = "3.4f";
            Console.WriteLine(Convert.ToDecimal(numero));
        }
    }
}
