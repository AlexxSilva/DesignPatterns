using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.Metodofabrica
{
    public class FreteFerroviarioFactory : IFreteFactory
    {
        public IFrete CriarFrete()
        {
            return new FreteFerroviario();
        }
    }
}
