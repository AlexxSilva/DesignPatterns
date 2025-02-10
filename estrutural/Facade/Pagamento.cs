using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Facade
{
    public class Pagamento
    {
        public bool ProcessarPagamento(string cartao)
        {
            Console.WriteLine($"Processando pagamento com o cartão: {cartao}");
            return true; // Suponha que o pagamento foi bem-sucedido
        }
    }
}
