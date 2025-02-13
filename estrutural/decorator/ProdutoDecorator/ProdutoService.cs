using DesignPatterns.estrutural.decorator.ProdutoDecorator.Interface;
using DesignPatterns.WMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator.ProdutoDecorator
{
    public class ProdutoService : IProdutoService
    {
        private readonly List<Produto> _produtos = new();

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Descricao} adicionado.");
        }

        public void Atualizar(Produto produto)
        {
            var existente = _produtos.FirstOrDefault(p => p.Id == produto.Id);
            if (existente != null)
            {
                existente.Codigo = produto.Codigo;
                existente.Descricao = produto.Descricao;
                existente.Preco = produto.Preco;
                existente.Estoque = produto.Estoque;
                Console.WriteLine($"Produto {produto.Descricao} atualizado.");
            }
        }

        public void Excluir(int id)
        {
            var produto = _produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                _produtos.Remove(produto);
                Console.WriteLine($"Produto {produto.Descricao} excluído.");
            }
        }

        public Produto? Obter(int id) => _produtos.FirstOrDefault(p => p.Id == id);
    }
}
