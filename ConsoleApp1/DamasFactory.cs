using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosFactoty
{
    public class DamasFactory : JuegoFactory
    {
        public override IJuego CrearJuego()
        {
            return new Damas();
        }
    }
}
