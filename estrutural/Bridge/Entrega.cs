using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Bridge
{
    public abstract class Entrega
    {
        protected ITransportadora transportadora;

        public Entrega(ITransportadora transportadora)
        {
            this.transportadora = transportadora;
        }

        public abstract void ProcessarEntrega(string pacote);
    }
}
