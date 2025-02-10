using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator
{
    abstract class DecoradorBebida : Bebida
    {
        protected Bebida _bebida;

        public DecoradorBebida(Bebida bebida)
        {
            _bebida = bebida;
        }

        // Sobrescreve a propriedade Descricao
        public override string Descricao => _bebida.Descricao;

        // Sobrescreve o método Custo
        public override double Custo() => _bebida.Custo();
    }
}
