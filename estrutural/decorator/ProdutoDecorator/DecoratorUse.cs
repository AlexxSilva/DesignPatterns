using DesignPatterns.estrutural.decorator.ProdutoDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator.ProdutoDecorator
{
    public class DecoratorUse
    {

        public void main()
        {
            IProdutoService produtoService = new ProdutoService();

            // Decoradores: Adicionando Validação e Log
            produtoService = new ValidacaoProdutoDecorator(produtoService);
            produtoService = new LogProdutoDecorator(produtoService);

            var produto = new Produto { Id = 1, Codigo= "001", Descricao = "Teclado", Preco = 150m, Estoque = 10 };

            produtoService.Adicionar(produto);
            produtoService.Atualizar(produto);
            produtoService.Obter(1);
            produtoService.Excluir(1);
        }
    }
}
