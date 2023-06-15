using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace HelloWorld
{
    internal class Bucles
    {
        public void BucleFor()
        {
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(contador);
            }

            for (int contador = 0; contador < 20; contador+=2)
            {
                Console.WriteLine(contador);
            }
        }

        public void BucleDoWhile()
        {
            int contador = 0;

            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador <= 10);
        }

        public void BucleWhile()
        {
            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

        public void BreakContinue()
        {
            for (int counter = 0; counter <= 10; counter++)
            {
                if (counter == 3)
                {
                    Console.WriteLine("Nos saltamos el 3");
                    continue;
                }
                
                Console.WriteLine(counter);
            }

            for (int numero = 0; numero <= 10; numero++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El siguiente es inpar");
                    continue;
                }

                Console.WriteLine(numero);
            }
        }

        public void DesafioBucles()
        {
            Console.WriteLine("Desafio de Loops");

            string ingreso = "0";
            int contador = 0;
            int total = 0;
            int numeroActual = 0;

            while (ingreso != "fin")
            {
                Console.WriteLine($"El numero actual es: {numeroActual}");
                Console.WriteLine($"Calificaciones ingresadas: {contador}");
                Console.WriteLine("Para finalizar escriba: 'fin'");
                Console.WriteLine("Ingrese la siguiente calificacion: ");

                ingreso = Console.ReadLine();

                if (ingreso.Equals("fin"))
                {
                    Console.WriteLine("=============");
                    

                    double promedio = (double) total / (double) contador;
                    Console.WriteLine($"El promedio es: {promedio}");

                } else if (int.TryParse(ingreso, out numeroActual) && numeroActual > 0 && numeroActual < 11)
                {
                    total += numeroActual;
                } else
                {
                    if (!(ingreso.Equals("fin")))
                    {
                        Console.WriteLine("Ingresa un numero entre 1 y 10");
                    }
                    continue;
                }
                contador++;
            }
        }
    }
}
