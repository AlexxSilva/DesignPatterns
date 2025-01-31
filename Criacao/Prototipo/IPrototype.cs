using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.Prototipo
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
