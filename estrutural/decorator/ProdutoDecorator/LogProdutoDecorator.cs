using DesignPatterns.estrutural.decorator.ProdutoDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator.ProdutoDecorator
{
    public class LogProdutoDecorator : ProdutoServiceDecorator
    {
        public LogProdutoDecorator(IProdutoService produtoService) : base(produtoService)
        {
        }

        public override void Adicionar(Produto produto)
        {
            Console.WriteLine($"[LOG] Adicionando produto: {produto.Descricao}");
            base.Adicionar(produto);
        }

        public override void Atualizar(Produto produto)
        {
            Console.WriteLine($"[LOG] Atualizando produto: {produto.Descricao}");
            base.Atualizar(produto);
        }

        public override void Excluir(int id)
        {
            Console.WriteLine($"[LOG] Excluindo produto com ID: {id}");
            base.Excluir(id);
        }

        public override Produto? Obter(int id)
        {
            Console.WriteLine($"[LOG] Buscando produto com ID: {id}");
            return base.Obter(id);
        }
    }
}
