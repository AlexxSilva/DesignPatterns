using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Facade
{
    public class Estoque
    {
        public bool VerificarEstoque(string produto)
        {
            Console.WriteLine($"Verificando estoque para: {produto}");
            return true; // Suponha que o produto está disponível
        }
    }
}
