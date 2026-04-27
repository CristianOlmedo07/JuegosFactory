using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosFactoty
{
    public class Damas : IJuego
    {
        public void Iniciar()
        {
            Console.WriteLine("Iniciando partida de Damas...");
        }

        public void MostrarReglas()
        {
            Console.WriteLine("Se juega moviendo piezas en diagonal.");
        }
    }
}
