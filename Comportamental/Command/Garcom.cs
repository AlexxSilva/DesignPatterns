using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Command
{
    public class Garcom
    {
        private List<IPedido> _pedidos = new List<IPedido>();

        public void AdicionarPedido(IPedido pedido)
        {
            _pedidos.Add(pedido);
        }

        public void ProcessarPedidos()
        {
            Console.WriteLine("Processando pedidos...");
            foreach (var pedido in _pedidos)
            {
                pedido.Executar();
            }
            _pedidos.Clear();
        }

        public void CancelarUltimoPedido()
        {
            if (_pedidos.Count > 0)
            {
                var pedido = _pedidos[_pedidos.Count - 1];
                _pedidos.RemoveAt(_pedidos.Count - 1);
                pedido.Cancelar();
            }
        }
    }
}
