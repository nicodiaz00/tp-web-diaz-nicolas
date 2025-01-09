using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public  static class Helper
    {
        public static bool campoVacio(string texto)
        {
            return !string.IsNullOrEmpty(texto);
        }

        public static bool ValidarDocumento(string texto)
        {
            return texto.Length == 8;
        }
        public static bool EsNumero(string texto)
        {
            int numero;
            return Int32.TryParse(texto, out numero);
        }
    }
}
