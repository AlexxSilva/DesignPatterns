using DesignPatterns.WMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Aplicacao.Factories
{
    public class NotaFiscalFactory
    {
        public NotaFiscal CriarNota(string numeroNota) => new()
        {
            NumeroNota = numeroNota,
            Emissao = DateTime.Now
        };

        public NotaFiscalItem AdicionarItemNaNota(NotaFiscal nota, Produto produto, decimal preco, decimal quantidade)
        {
            var item = new NotaFiscalItem
            {
                ProdutoId = produto.Id,
                PrecoUnitario = preco,
                Quantidade = quantidade
            };
            nota.Itens.Add(item);
            return item;
        }

        public Lote CriarLote(NotaFiscalItem item, string numeroLote, decimal quantidade) => new()
        {
            NotaFiscalItemId = item.Id,
            ProdutoId = item.ProdutoId,
            NumeroLote = numeroLote,
            Quantidade = quantidade
        };
    }
}
