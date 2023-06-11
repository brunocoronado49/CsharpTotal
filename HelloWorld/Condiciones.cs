using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Condiciones
    {
        public void Desiciones()
        {
            byte edad;
            Console.Write("Ingresa tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            } else
            {
                Console.WriteLine("Eres menor de edad, no puedes beber.");
            }

            double clima = 7.10;

            if (clima <= 10)
            {
                Console.WriteLine("Es un buen clima.");
            } else
            {
                Console.WriteLine("No me agrada el clima.");
            }

            Console.Write("Ingresa un numero: ");
            string numeroString = Console.ReadLine();
            int numeroParseado;

            bool sePudo = int.TryParse(numeroString, out numeroParseado);

            if (sePudo)
            {
                Console.WriteLine($"Si se pudo {sePudo} - {numeroParseado}");
            } else
            {
                Console.WriteLine("No se pudo :(, intenta de nuevo");
            }
        }

        public void IfAnidados()
        {
            bool isAdmin, isRegistrado = true;
            string? nombreUsuario;

            Console.Write("Ingresa tu nombre: ");
            nombreUsuario = Console.ReadLine();

            if (isRegistrado)
            {
                Console.WriteLine("Hello User registered!");

                if (nombreUsuario != "")
                {
                    Console.WriteLine($"Hola {nombreUsuario}");

                    if (nombreUsuario!.Equals("admin"))
                    {
                        isAdmin = true;
                        Console.WriteLine($"Eres administrador {isAdmin}");
                    } else
                    {
                        isAdmin = false;
                        Console.WriteLine($"NO eres administrador {isAdmin}");
                    }
                } else
                {
                    Console.WriteLine("Nobody");
                }
            }
        }

        public void DesafioLogin()
        {
            string username = "brucedjarin";
            string password = "061097jfrc";
            bool logged;

            Console.Write("Ingresa tu username: ");
            string? inputUsername = Console.ReadLine();

            Console.Write("Ingresa tu password: ");
            string? inputPassword = Console.ReadLine();

            if (username == inputUsername && password == inputPassword)
            {
                logged = true;
                Console.WriteLine($"Bienvenido :D login: {logged}");
            } else
            {
                Console.WriteLine("Lo siento, tus credenciales son malas.");
            }
        }
    }
}
