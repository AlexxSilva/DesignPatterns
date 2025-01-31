using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.Metodofabrica
{
    public class FreteAereoFactory : IFreteFactory
    {
        private decimal _taxaSeguranca;
        public FreteAereoFactory(decimal _taxaSeguranca)
        {
            this._taxaSeguranca = _taxaSeguranca;
        }

        public IFrete CriarFrete()
        {
            return new FreteAereo(_taxaSeguranca);
        }
    }
}
