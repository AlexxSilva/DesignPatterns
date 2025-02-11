using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Memento
{
    public class Memento
    {
        public string Estado { get; }

        public Memento(string estado)
        {
            Estado = estado;
        }
    }
}
