using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator
{
    class Chantilly : DecoradorBebida
    {
        public Chantilly(Bebida bebida) : base(bebida)
        {
        }

        // Adiciona ", Chantilly" à descrição da bebida base
        public override string Descricao => _bebida.Descricao + ", Chantilly";

        // Adiciona 3.0 ao custo da bebida base
        public override double Custo() => _bebida.Custo() + 3.0;
    }
}
