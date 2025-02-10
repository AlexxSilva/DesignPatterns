using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.TemplateMethod
{
    class PagamentoPayPal : Pagamento
    {
        protected override void ValidarDados()
        {
            Console.WriteLine("Validando conta do PayPal...");
        }

        protected override bool AutorizarPagamento()
        {
            Console.WriteLine("Autorizando pagamento via PayPal...");
            return false; // Simulando uma falha na autorização
        }

        protected override void ConfirmarPagamento()
        {
            //a confirmação do pagamento também envia um sms
            base.ConfirmarPagamento();
        }
    }
}
