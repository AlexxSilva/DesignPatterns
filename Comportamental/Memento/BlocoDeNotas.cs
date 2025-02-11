using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Memento
{
    public class BlocoDeNotas
    {
        private string _conteudo;

        public void Escrever(string texto)
        {
            _conteudo = texto;
            Console.WriteLine($"Estado atual: {_conteudo}");
        }

        public Memento CriarMemento()
        {
            return new Memento(_conteudo);
        }

        public void RestaurarMemento(Memento memento)
        {
            _conteudo = memento.Estado;
            Console.WriteLine($"↩️ Estado restaurado: {_conteudo}");
        }
    }
}
