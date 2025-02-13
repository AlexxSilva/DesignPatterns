using DesignPatterns.WMS.Dominio.Entidades;
using DesignPatterns.WMS.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Aplicacao.Strategies
{
    public class EstrategiaEnderecamentoFIFO : IEstrategiaEnderecamento
    {
        private readonly IRepository<Endereco> _repository;

        public EstrategiaEnderecamentoFIFO(IRepository<Endereco> repository) => _repository = repository;

        public Endereco? EncontrarEnderecoDisponivel(Produto produto) =>
            _repository.ObterTodos().OrderBy(e => e.Id).FirstOrDefault();
    }
}
