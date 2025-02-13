using DesignPatterns.WMS.Dominio.Entidades;
using DesignPatterns.WMS.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Aplicacao.Observers
{
    public class NotificadorEmail : IObservadorEstoque
    {
        public void Atualizar(Produto produto, decimal quantidadeAnterior, decimal novaQuantidade)
        {
            if (novaQuantidade < produto.QuantidadeMinima)
                Console.WriteLine($"[EMAIL] Estoque baixo: {produto.Descricao} ({novaQuantidade} {produto.Unidade})");
        }
    }
}
