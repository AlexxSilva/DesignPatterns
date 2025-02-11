using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Observer
{
    public interface IInvestidor
    {
        void Atualizar(string simbolo, double preco);
    }
}
