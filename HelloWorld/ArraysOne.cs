using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ArraysOne
    {
        public void Arreglos()
        {
            // maneras de declarar un array
            int[] calificaciones = new int[5];
            int[] edades = { 10, 8, 7, 7, 9 };
            int[] faltas = new int[] { 1, 3, 5, 4, 2, 7 };

            Console.WriteLine($"Length de edades: {edades.Length}");
            Console.WriteLine($"Length de faltas: {faltas.Length}");

            calificaciones[0] = 10;
            calificaciones[1] = 6;
            calificaciones[2] = 5;
            calificaciones[3] = 7;
            calificaciones[4] = 9;

            Console.WriteLine($"Primer calificacion: {calificaciones[0]}");

            Console.Write("Ingresa la nueva calificacion: ");
            string ingreso = Console.ReadLine();
            int nuevaCalificacion = int.Parse(ingreso);
            calificaciones[0] = nuevaCalificacion;

            Console.WriteLine($"Nueva calificacion: {calificaciones[0]}");

            // foreach
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
            }

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            string[] nombresAmigos = {"Jose", "Juan", "David", "Aron", "Franco"};

            foreach (string nombre in nombresAmigos)
            {
                Console.WriteLine($"Hola {nombre}");
            }
        }

        public void ArrayMultidimencional()
        {
            // declaracion array de dos dimenciones
            string[,] matriz2D;

            // array de 3 dimensiones
            int[,,] matriz3D;

            string[,] array2D = new string[,]
            {
                // 0    1   2
                {"a", "b", "c"}, // 0
                {"d", "e", "f"}, // 1
                {"g", "h", "i"}  // 2
            };

            Console.WriteLine($"Valor del array en sus indices: {array2D[1,1]}");
            Console.WriteLine($"El valor es g: {array2D[2,0]}");
        }
        
        public void ArrayTridimencinal()
        {
            string[,,] array3D = new string[,,]
            {
                // 0
                {
                    // 0    1   2
                    {"a", "b", "c"}, // 0
                    {"d", "e", "f"}, // 1
                    {"g", "h", "i"}  // 2
                },
                // 1
                {
                    {"j", "k", "l" },
                    { "m", "n", "o"},
                    { "p", "q", "r"}
                },
                //2
                {
                    {"s", "t", "u" },
                    { "v", "w", "x"},
                    { "y", "z", "zz"}
                },

            };

            Console.WriteLine($"el valor de A es: {array3D[0,0,0]}");
            Console.WriteLine($"el valor de j es: {array3D[1, 0, 0]}");
            Console.WriteLine($"el valor de v es: {array3D[2, 1, 0]}");
        }
    }
}
