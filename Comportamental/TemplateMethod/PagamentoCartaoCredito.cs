using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.TemplateMethod
{
    public class PagamentoCartaoCredito : Pagamento
    {
        protected override void ValidarDados()
        {
            Console.WriteLine("Validando dados do cartão de crédito...");
        }

        protected override bool AutorizarPagamento()
        {
            Console.WriteLine("Autorizando pagamento via cartão de crédito...");
            return true; // Simulando uma autorização bem-sucedida
        }
    }
}
