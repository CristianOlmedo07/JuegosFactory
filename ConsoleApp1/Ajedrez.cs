using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosFactoty
{
    public class Ajedrez : IJuego
    {
        public void Iniciar()
        {
            Console.WriteLine("Iniciando partida de Ajedrez...");
        }

        public void MostrarReglas()
        {
            Console.WriteLine("Juego estratégico con 16 piezas.");
        }
    }
}
