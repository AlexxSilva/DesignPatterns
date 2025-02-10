using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Facade
{
    public class PedidoFacade
    {
        private Estoque _estoque;
        private Pagamento _pagamento;
        private Notificacao _notificacao;

        public PedidoFacade()
        {
            _estoque = new Estoque();
            _pagamento = new Pagamento();
            _notificacao = new Notificacao();
        }

        public void FazerPedido(string produto, string cartao, string email)
        {
            Console.WriteLine("\nIniciando processo de pedido...\n");

            if (!_estoque.VerificarEstoque(produto))
            {
                Console.WriteLine("Produto indisponível.");
                return;
            }

            if (!_pagamento.ProcessarPagamento(cartao))
            {
                Console.WriteLine("Falha no pagamento.");
                return;
            }

            _notificacao.EnviarEmail(email);

            Console.WriteLine("\nPedido realizado com sucesso!\n");
        }

    }
}
