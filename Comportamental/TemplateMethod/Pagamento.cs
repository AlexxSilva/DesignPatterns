using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.TemplateMethod
{
    public abstract class Pagamento
    {
        // Template Method - Define o fluxo do pagamento
        public void Processar()
        {
            ValidarDados();
            if (AutorizarPagamento())
            {
                ConfirmarPagamento();
            }
            else
            {
                Console.WriteLine("Pagamento não autorizado.\n");
            }
        }

        protected abstract void ValidarDados();
        protected abstract bool AutorizarPagamento();
        protected virtual void ConfirmarPagamento()
        {
            Console.WriteLine("Pagamento confirmado e email enviado!\n");
        }
    }
}
