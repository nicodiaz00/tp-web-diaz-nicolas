using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public  static class Helper
    {
        public static bool ValidarMinimoCaracteres(string texto)
        {
            return !string.IsNullOrEmpty(texto);
        }
    }
}
