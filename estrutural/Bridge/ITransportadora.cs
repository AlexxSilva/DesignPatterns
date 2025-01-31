using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Bridge
{
    public interface ITransportadora
    {
        void Entregar(string pacote);
    }
}
