using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Bridge
{
    internal class Caminhao : ITransportadora
    {
        public void Entregar(string pacote)
        {
            Console.WriteLine($"Entregando {pacote} via Caminhão.");
        }
    }
}
