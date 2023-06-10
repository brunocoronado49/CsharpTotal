using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Metodos
    {
        // especificador de acceso - tipo de retorno - nombre del metodo - lista de params
        public void MetodoVoid()
        {
            // cuerpo del metodo
            Console.WriteLine("Metodo void");
        }

        /*
        Especificador de acceso:
            determina la visibilidad de una variable o metodo desde otra clase
        
        Tipo de retorno:
            puede devolver un valor, el tipo de retorno es  el tipo de dato
            del valor que va a devolver el metodo, si el metodo no devuelve nada
            el tipo de retorno es void
        
        lista de params:
            encerrados en el parentesis, los parametros se usan para pasar y 
            recibir datos en un metodo. La lista se refere al tipo, orden y canridad
            de parametros en un metodo, son opcionales y pueden no incluirse
         */

        public int SumarNumeros(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public string SaludarPersona(string nomrbe)
        {
            return $"Hola {nomrbe}";
        }

        public bool MayorEdad(int edad)
        {
            if (edad >= 0)
            {
                return true;
            }
            return false;
        }

        public string SaludarAmigos(string manix)
        {
            return $"Que onda manix {manix}, saca las kawasakis!";
        }
    }
}
