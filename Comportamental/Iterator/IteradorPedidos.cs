using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Iterator
{
    public class IteradorPedidos : IIteradorPedidos
    {
        private readonly List<Pedido> _pedidos;
        private int _indiceAtual = 0;

        public IteradorPedidos(List<Pedido> pedidos)
        {
            _pedidos = pedidos;
        }

        public bool TemProximo()
        {
            return _indiceAtual < _pedidos.Count;
        }

        public Pedido Proximo()
        {
            return _pedidos[_indiceAtual++];
        }
    }
}
