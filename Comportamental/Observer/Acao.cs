using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Observer
{
    public class Acao
    {
        private readonly List<IInvestidor> _investidores = new();
        private double _preco;

        public string Simbolo { get; }

        public Acao(string simbolo, double preco)
        {
            Simbolo = simbolo;
            _preco = preco;
        }

        public void AdicionarInvestidor(IInvestidor investidor)
        {
            _investidores.Add(investidor);
        }

        public void RemoverInvestidor(IInvestidor investidor)
        {
            _investidores.Remove(investidor);
        }

        public void AtualizarPreco(double novoPreco)
        {
            if (_preco != novoPreco) // Notifica apenas se houver mudança
            {
                _preco = novoPreco;
                NotificarInvestidores();
            }
        }

        private void NotificarInvestidores()
        {
            Console.WriteLine($" Notificação: A ação {Simbolo} mudou para R${_preco:F2}");
            foreach (var investidor in _investidores)
            {
                investidor.Atualizar(Simbolo, _preco);
            }
        }
    }
}
