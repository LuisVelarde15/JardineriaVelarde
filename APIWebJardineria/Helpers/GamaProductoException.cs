using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebJardineria.Helpers
{
    public class GamaProductoException :  Exception
    {
        public GamaProductoException(string Mensaje) : base(Mensaje)
        {

        }
    }
}
