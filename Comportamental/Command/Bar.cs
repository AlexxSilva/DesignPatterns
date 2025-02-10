using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Command
{
    public class Bar
    {
        public void PrepararBebida(string bebida)
        {
            Console.WriteLine($"Bar preparando: {bebida}");
        }

        public void CancelarBebida(string bebida)
        {
            Console.WriteLine($"Pedido cancelado no bar: {bebida}");
        }
    }
}
