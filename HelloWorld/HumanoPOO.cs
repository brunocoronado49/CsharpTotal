using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HumanoPOO
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string? ocupacion;

        // constructor por defecto
        public HumanoPOO()
        {
            Console.WriteLine("Constructor por defecto.");
        }

        // constructor parametrizado
        public HumanoPOO(string nombre, string apellido, int edad, string? ocupacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.ocupacion = ocupacion;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola! soy {nombre} {apellido} y tengo {edad} de edad");
        }

        public void Trabajo()
        {
            if (ocupacion != null)
            {
                Console.WriteLine($"Soy {ocupacion}");
            } else
            {
                Console.WriteLine("No tengo oficio.");
            }
        }
    }
}
