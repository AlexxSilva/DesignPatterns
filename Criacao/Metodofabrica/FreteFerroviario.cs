using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.Metodofabrica
{
    public class FreteFerroviario : IFrete
    {
        public void CalcularFrete()
        {
            Console.WriteLine("Frete ferroviario calculado.");
        }
    }
}
