using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Observer
{
    public class Investidor : IInvestidor
    {
        public string Nome { get; }

        public Investidor(string nome)
        {
            Nome = nome;
        }

        public void Atualizar(string simbolo, double preco)
        {
            Console.WriteLine($"{Nome} foi notificado: A ação {simbolo} agora custa R${preco:F2}");
        }
    }
}
