using DesignPatterns.WMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.decorator.ProdutoDecorator.Interface
{
    public interface IProdutoService
    {
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Excluir(int id);
        Produto? Obter(int id);
    }
}
