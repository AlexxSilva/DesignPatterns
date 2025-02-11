using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Memento
{
    public class Historico
    {
        private readonly Stack<Memento> _mementos = new();

        public void SalvarEstado(Memento memento)
        {
            _mementos.Push(memento);
        }

        public Memento? Desfazer()
        {
            return _mementos.Count > 0 ? _mementos.Pop() : null;
        }
    }
}
