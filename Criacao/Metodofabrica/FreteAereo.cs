using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.Metodofabrica
{
    public class FreteAereo : IFrete
    {
        private decimal _taxaSeguranca;

        public FreteAereo(decimal taxaSeguranca)
        {
                this._taxaSeguranca = taxaSeguranca;
        }

        public void CalcularFrete()
        {
            Console.WriteLine($"Frete aéreo calculado com taxa de segurança de {_taxaSeguranca}%.");
        }
    }
}
