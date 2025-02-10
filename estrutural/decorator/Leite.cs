using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator
{
    class Leite : DecoradorBebida
    {
        public Leite(Bebida bebida) : base(bebida)
        {
        }

        // Adiciona ", Leite" à descrição da bebida base
        public override string Descricao => _bebida.Descricao + ", Leite";

        // Adiciona 2.0 ao custo da bebida base
        public override double Custo() => _bebida.Custo() + 2.0;
    }
}
