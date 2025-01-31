using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Bridge
{
    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa(ITransportadora transportadora) : base(transportadora)
        {
        }

        public override void ProcessarEntrega(string pacote)
        {
            Console.WriteLine("Entrega Expressa iniciada...");
            transportadora.Entregar(pacote);
        }
    }
}
