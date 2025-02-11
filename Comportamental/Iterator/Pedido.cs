using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Iterator
{
    public class Pedido
    {
        public int Id { get; }
        public string Cliente { get; }
        public string Descricao { get; }

        public Pedido(int id, string cliente, string descricao)
        {
            Id = id;
            Cliente = cliente;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"Pedido #{Id} - Cliente: {Cliente}, Prato: {Descricao}";
        }
    }
}
