using DesignPatterns.WMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Interfaces
{
    public interface IEstoqueService
    {
        void ProcessarNotaCompleta(string numeroNota, List<(Produto produto, decimal preco, decimal quantidade)> itens);
        void EnderecarLotesDaNota(int notaId, Dictionary<int, Endereco> enderecosPorItem);
        Produto? ObterProduto(int id);
    }
}
