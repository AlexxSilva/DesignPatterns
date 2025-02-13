using DesignPatterns.WMS.Aplicacao.Factories;
using DesignPatterns.WMS.Dominio.Entidades;
using DesignPatterns.WMS.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Aplicacao.Services
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IUnitOfWork _uow;
        private readonly NotaFiscalFactory _factory;
        private readonly EnderecamentoService _enderecamento;
        private readonly List<IObservadorEstoque> _observadores = new();

        public EstoqueService(IUnitOfWork uow, NotaFiscalFactory factory, EnderecamentoService enderecamento)
        {
            _uow = uow;
            _factory = factory;
            _enderecamento = enderecamento;
        }

        public void RegistrarObservador(IObservadorEstoque observador) => _observadores.Add(observador);

        public void ProcessarNotaCompleta(string numeroNota, List<(Produto produto, decimal preco, decimal quantidade)> itens)
        {
            var nota = _factory.CriarNota(numeroNota);

            foreach (var item in itens)
            {
                var quantidadeAnterior = item.produto.QtdeTotal;
                var notaItem = _factory.AdicionarItemNaNota(nota, item.produto, item.preco, item.quantidade);

                var endereco = _enderecamento.EncontrarEnderecoDisponivel(item.produto) ??
                    throw new InvalidOperationException("Endereço não encontrado");

                var lote = _factory.CriarLote(notaItem, GerarNumeroLote(), item.quantidade);
                _enderecamento.EnderecarLote(lote, endereco);

                AtualizarEstoque(item.produto, item.quantidade);
                NotificarObservadores(item.produto, quantidadeAnterior);
            }

            _uow.NotasFiscais.Adicionar(nota);
            _uow.Commit();
        }

        public Produto? ObterProduto(int id) => _uow.Produtos.ObterPorId(id);

        private void NotificarObservadores(Produto produto, decimal quantidadeAnterior)
        {
            foreach (var obs in _observadores)
                obs.Atualizar(produto, quantidadeAnterior, produto.QtdeTotal);
        }

        private static string GerarNumeroLote() => $"LOTE-{DateTime.Now:yyyyMMdd-HHmmss}";
        private void AtualizarEstoque(Produto produto, decimal quantidade) => produto.QtdeTotal += quantidade;

        public void EnderecarLotesDaNota(int notaId, Dictionary<int, Endereco> enderecosPorItem)
        {
            var nota = _uow.NotasFiscais.ObterPorId(notaId) ??
                throw new ArgumentException("Nota fiscal não encontrada");

            foreach (var item in nota.Itens)
            {
                if (enderecosPorItem.TryGetValue(item.Id, out var endereco))
                {
                    foreach (var lote in item.Lotes)
                    {
                        _enderecamento.EnderecarLote(lote, endereco);
                    }
                }
            }
            _uow.Commit();
        }
    }
}
