using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosFactoty
{
    class Program
    {
        static void Main(string[] args)
        {
            JuegoFactory factory = null;

            Console.WriteLine("Seleccione un juego:");
            Console.WriteLine("1. Ajedrez");
            Console.WriteLine("2. Damas");
            Console.WriteLine("3. Dominó");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    factory = new AjedrezFactory();
                    break;

                case "2":
                    factory = new DamasFactory();
                    break;

                case "3":
                    factory = new DominoFactory();
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    return;
            }

            IJuego juego = factory.CrearJuego();

            juego.Iniciar();
            juego.MostrarReglas();

            Console.ReadKey();
        }
    }
}
