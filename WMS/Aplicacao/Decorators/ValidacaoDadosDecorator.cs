using DesignPatterns.WMS.Dominio.Entidades;
using DesignPatterns.WMS.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Aplicacao.Decorators
{
    public class ValidacaoDadosDecorator : IEstoqueService
    {
        private readonly IEstoqueService _service;

        public ValidacaoDadosDecorator(IEstoqueService service) => _service = service;

        public void ProcessarNotaCompleta(string numeroNota, List<(Produto produto, decimal preco, decimal quantidade)> itens)
        {
            if (string.IsNullOrWhiteSpace(numeroNota))
                throw new ArgumentException("Número da nota inválido");

            foreach (var item in itens)
            {
                if (item.quantidade <= 0)
                    throw new ArgumentException($"Quantidade inválida: {item.produto.Descricao}");

                if (item.preco <= 0)
                    throw new ArgumentException($"Preço inválido: {item.produto.Descricao}");
            }

            _service.ProcessarNotaCompleta(numeroNota, itens);
        }

        public void EnderecarLotesDaNota(int notaId, Dictionary<int, Endereco> enderecosPorItem) =>
            _service.EnderecarLotesDaNota(notaId, enderecosPorItem);

        public Produto? ObterProduto(int id) => _service.ObterProduto(id);
    }
}
