using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Caja
    {
        // miembros variables
        public int largo;
        public int alto;
        public int ancho;
        public int volumen;

        // miembro metodo
        public void MostrarInfo()
        {
            Console.WriteLine($"Largo: {largo} - Ancho: {ancho} - Alto: {alto} - Volumen: {volumen = ancho * alto * largo}");
        }

    }
}
