using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.composite
{
    public class Pasta : ComponenteSistemaArquivos
    {
        private List<ComponenteSistemaArquivos> _filhos = new List<ComponenteSistemaArquivos>();
        public Pasta(string nome) : base(nome)
        {
        }

        public void Adicionar(ComponenteSistemaArquivos componente)
        {
            _filhos.Add(componente);
        }

        public void Remover(ComponenteSistemaArquivos componente)
        {
            _filhos.Remove(componente);
        }

        public override void Exibir(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + Nome);

            // Exibe cada filho recursivamente
            foreach (var componente in _filhos)
            {
                componente.Exibir(profundidade + 2);
            }
        }
    }
}
