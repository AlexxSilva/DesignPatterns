using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Iterator
{
    public class ListaPedidos : IColecaoPedidos
    {
        private readonly List<Pedido> _pedidos = new();

        public void AdicionarPedido(Pedido pedido)
        {
            _pedidos.Add(pedido);
        }

        public IIteradorPedidos CriarIterador()
        {
            return new IteradorPedidos(_pedidos);
        }
    }
}
