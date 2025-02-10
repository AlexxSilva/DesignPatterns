using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Command
{
    public class Cozinha
    {
        public void PrepararComida(string prato)
        {
            Console.WriteLine($"Cozinha preparando: {prato}");
        }

        public void CancelarComida(string prato)
        {
            Console.WriteLine($"Pedido cancelado na cozinha: {prato}");
        }
    }
}
