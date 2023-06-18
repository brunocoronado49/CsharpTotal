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
        //private int largo;
        //private int alto;
        //private int ancho;
        private int volumen;

        // propiedad autoimplementada
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }

        // miembro metodo
        public void MostrarInfo()
        {
            Console.WriteLine($"Largo: {Largo} - Ancho: {Ancho} - Alto: {Alto} - Volumen: {volumen = Ancho * Alto * Largo}");
        }

        // metodo largo
        /*public int Largo
        {
            get { return largo; }
            set { largo = value; }
        }*/

        // metodo antiguo
        /*public void SetLargo(int largo)
        {
            this.largo = largo;
        }

        public int GetLargo()
        {
            return this.largo;
        }*/
    }
}
