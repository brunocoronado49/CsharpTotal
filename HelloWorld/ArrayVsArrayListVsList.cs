using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ArrayVsArrayListVsList
    {
        public void Diferencias()
        {
            // array inmutable y limitado a tipo de dato
            int[] puntajes = new int[] { 99, 96, 87, 76 };

            // lista, se pueden agregar elementos
            List<int> lista = new List<int> { 1, 2, 3, 4 };

            lista.Add(0);
            lista.Add(32);
            lista.Sort();
            lista.RemoveRange(2,2);

            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(lista.Contains(4));

            int indice = lista.FindIndex(x => x == 4);
            Console.WriteLine(lista[indice]);
            lista.RemoveAt(indice);

            lista.ForEach(i => Console.WriteLine(i));

            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("dos");
            arrList.Add(true);
            arrList.Add(new Numero { numero = 4 });

            foreach(Object varios in arrList)
            {
                Console.WriteLine(varios);
            }
        }
    }

    class Numero
    {
        public int numero { get; set; }

        public override string ToString()
        {
            return numero.ToString();
        }
    }
}
