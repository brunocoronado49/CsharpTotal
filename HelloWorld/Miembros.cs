using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Miembros
    {
        private string nombre;
        private string titulo;
        private int salario;

        public int edad;

        public string Titulo { get { return titulo; } set { titulo = value; } }

        private void CompartirInfoPrivada()
        {
            Console.WriteLine($"Mi salario es: {salario}");
        }

        public void CompartirInfoPublica(bool amigo)
        {
            if (amigo)
            {
                CompartirInfoPrivada();
            } else
            {
                Console.WriteLine($"Hola me llamo {nombre} y tengo {edad} de edad y soy {titulo}");
            }
        }

        public Miembros()
        {
            edad = 25;
            nombre = "Francisco";
            salario = 25000;
            titulo = "Programador";
            Console.WriteLine("Objeto creado");
        }

        // destrutor/finalizador
        ~Miembros()
        {
            Debug.Write("AAAAAA Objeto destruido");
        }
    }
}
