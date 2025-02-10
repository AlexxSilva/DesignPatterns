using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator
{
    abstract class Bebida
    {
        // Propriedade abstrata (deve ser implementada nas classes derivadas)
        public abstract string Descricao { get; }

        // Método abstrato (deve ser implementado nas classes derivadas)
        public abstract double Custo();
    }
}
