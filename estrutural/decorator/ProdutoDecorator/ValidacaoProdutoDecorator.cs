using DesignPatterns.estrutural.decorator.ProdutoDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator.ProdutoDecorator
{
    public class ValidacaoProdutoDecorator : ProdutoServiceDecorator
    {
        public ValidacaoProdutoDecorator(IProdutoService produtoService) : base(produtoService)
        {
        }

        public override void Adicionar(Produto produto)
        {
            ValidarProduto(produto);
            base.Adicionar(produto);
        }

        public override void Atualizar(Produto produto)
        {
            ValidarProduto(produto);
            base.Atualizar(produto);
        }

        private void ValidarProduto(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Codigo))
                throw new ArgumentException("Código do produto não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(produto.Descricao))
                throw new ArgumentException("Descrição do produto não pode ser vazia.");

            if (produto.Preco <= 0)
                throw new ArgumentException("Preço deve ser maior que zero.");

            if (produto.Estoque < 0)
                throw new ArgumentException("Estoque não pode ser negativo.");
        }
    }
}
