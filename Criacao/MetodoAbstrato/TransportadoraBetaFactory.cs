using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.MetodoAbstrato
{
    public class TransportadoraBetaFactory : ITransportadoraFactory
    {
        public IFrete CriarFreteNavio()
        {
            throw new NotSupportedException("Transportadora Beta não oferece frete de navio.");
        }

        public IFrete CriarFreteAereo(decimal _taxaseguranca)
        {
            throw new NotSupportedException("Transportadora Beta não oferece frete aéreo.");
        }

        public IFrete CriarFreteFerroviario()
        {
            return new FreteFerroviario();
        }

       
    }
}
