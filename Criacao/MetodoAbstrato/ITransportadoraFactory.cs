using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.MetodoAbstrato
{
    public interface ITransportadoraFactory
    {
        IFrete CriarFreteNavio();
        IFrete CriarFreteAereo(decimal taxaSeguranca);
        IFrete CriarFreteFerroviario();
    }
}
