using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator
{
    class Chocolate : DecoradorBebida
    {
        public Chocolate(Bebida bebida) : base(bebida)
        {
        }

        // Adiciona ", Chocolate" à descrição da bebida base
        public override string Descricao => _bebida.Descricao + ", Chocolate";

        // Adiciona 4.0 ao custo da bebida base
        public override double Custo() => _bebida.Custo() + 4.0;
    }
}
