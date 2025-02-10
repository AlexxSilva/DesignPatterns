using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.composite
{
    public abstract class ComponenteSistemaArquivos
    {
        public string Nome { get; }

        protected ComponenteSistemaArquivos(string nome)
        {
            Nome = nome;
        }

        public abstract void Exibir(int profundidade);
    }
}
