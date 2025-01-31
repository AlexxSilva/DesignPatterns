using DesignPatterns.Criacao.Metodofabrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.MetodoAbstrato
{
    public class TransportadoraAlphaFactory : ITransportadoraFactory
    {
        public IFrete CriarFreteNavio()
        {
            return new FreteMaritimo();
        }
        public IFrete CriarFreteAereo(decimal taxaSeguranca)
        {
            return new FreteAereo(taxaSeguranca);
        }

        public IFrete CriarFreteFerroviario()
        {
            throw new NotSupportedException("Transportadora Alpha não oferece frete ferroviário.");
        }

        public IFrete CriarFreteRodoviario()
        {
            throw new NotSupportedException("Transportadora Alpha não oferece frete rodoviário.");
        }       
    }
}
