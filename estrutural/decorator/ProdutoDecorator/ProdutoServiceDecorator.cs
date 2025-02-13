using DesignPatterns.estrutural.decorator.ProdutoDecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator.ProdutoDecorator
{
    public abstract class ProdutoServiceDecorator : IProdutoService
    {
        protected readonly IProdutoService _produtoService;

        public ProdutoServiceDecorator(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public virtual void Adicionar(Produto produto) => _produtoService.Adicionar(produto);
        public virtual void Atualizar(Produto produto) => _produtoService.Atualizar(produto);
        public virtual void Excluir(int id) => _produtoService.Excluir(id);
        public virtual Produto? Obter(int id) => _produtoService.Obter(id);
    }
}
