using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator
{
    class Cafe : Bebida
    {
        public override string Descricao => "Café simples"; // Implementação da propriedade
        public override double Custo() => 5.0; // Implementação do método
    }
}
