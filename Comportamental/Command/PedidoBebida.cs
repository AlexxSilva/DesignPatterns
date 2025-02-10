using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Command
{
    public class PedidoBebida : IPedido
    {
        private Bar _bar;
        private string _bebida;

        public PedidoBebida(Bar bar, string bebida)
        {
            _bar = bar;
            _bebida = bebida;
        }

        public void Executar()
        {
            _bar.PrepararBebida(_bebida);
        }

        public void Cancelar()
        {
            _bar.CancelarBebida(_bebida);
        }
    }
}
