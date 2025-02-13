using DesignPatterns.WMS.Dominio.Entidades;
using DesignPatterns.WMS.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Aplicacao.Services
{
    public class EnderecamentoService
    {
        private readonly IEstrategiaEnderecamento _estrategia;

        public EnderecamentoService(IEstrategiaEnderecamento estrategia) => _estrategia = estrategia;

        public void EnderecarLote(Lote lote, Endereco endereco)
        {
            lote.EnderecoId = endereco.Id;
            Console.WriteLine($"Lote {lote.NumeroLote} endereçado para {endereco.Rua}/{endereco.Prateleira}");
        }

        public Endereco? EncontrarEnderecoDisponivel(Produto produto) => _estrategia.EncontrarEnderecoDisponivel(produto);
    }
}
