using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ArraysTwo
    {
        public void ArrayIrregular()
        {
            int[][] irregular = new int[3][];

            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[7];

            irregular[0] = new int[] {2, 3, 8, 9, 11};
            irregular[1] = new int[] {3, 40, 15};
            irregular[2] = new int[] {5, 37};

            int[][] irregular2 = new int[][] 
            {
                new int[] {2, 3, 8, 9, 11},
                new int[] {3, 40, 15},
                new int[] {5, 37},
            };

            Console.WriteLine($"Valor en el indice del primer array: {irregular2[0][2]}");

            for (int i = 0; i < irregular2.Length; i++)
            {
                Console.WriteLine($"Los valores del array: {i}");
                
                for (int j = 0; j < irregular2[i].Length; j++)
                {
                    Console.WriteLine($"El valor es: {irregular2[i][j]}");
                }
            }
        }


        public void DesafioIrregular()
        {
            string[][] juegos = new string[][]
            {
                new string[] {"resident evil", "assassins creed", "outlast", "fran bow", "hollow"},
                new string[] {"metal gear", "halo", "gears of war", "the witcher"},
                new string[] {"cyberpunk 2077", "batman arkham", "crash bandicoot"}
            };

            Console.WriteLine($"Hola {juegos[0][0]} te presento a {juegos[2][2]}");
            Console.WriteLine($"Hola {juegos[1][3]} te presento a {juegos[0][4]}");
            Console.WriteLine($"Hola {juegos[0][2]} te presento a {juegos[2][1]}");
            Console.WriteLine($"Hola {juegos[2][0]} te presento a {juegos[1][3]}");

            for (int i = 0; i < juegos.Length; i++)
            {
                for (int j = 0; j < juegos[i].Length; j++)
                {
                    Console.WriteLine($"mi juego favorito es {juegos[i][j]}");
                }
            }
        }
    }
}
