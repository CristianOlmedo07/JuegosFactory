using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosFactoty
{
    public class Domino : IJuego
    {
        public void Iniciar()
        {
            Console.WriteLine("Iniciando partida de Dominó...");
        }

        public void MostrarReglas()
        {
            Console.WriteLine("Une fichas iguales para ganar.");
        }
    }
}
