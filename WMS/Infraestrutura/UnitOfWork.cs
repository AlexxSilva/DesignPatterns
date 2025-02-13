using DesignPatterns.WMS.Dominio.Entidades;
using DesignPatterns.WMS.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Infraestrutura
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<NotaFiscal> NotasFiscais { get; } = new MemoryRepository<NotaFiscal>();
        public IRepository<Produto> Produtos { get; } = new MemoryRepository<Produto>();
        public IRepository<Endereco> Enderecos { get; } = new MemoryRepository<Endereco>();
        public void Commit() => Console.WriteLine("Dados persistidos com sucesso");
    }
}
