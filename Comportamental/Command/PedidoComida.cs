using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Command
{
    internal class PedidoComida : IPedido
    {
        private Cozinha _cozinha;
        private string _prato;

        public PedidoComida(Cozinha cozinha, string prato)
        {
            _cozinha = cozinha;
            _prato = prato;
        }
        public void Executar()
        {
            _cozinha.PrepararComida(_prato);
        }

        public void Cancelar()
        {
            _cozinha.CancelarComida(_prato);
        }
    }
}
