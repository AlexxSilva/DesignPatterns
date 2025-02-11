using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Visitor
{
    public class Desenvolvedor : Funcionario
    {
        public string Linguagem { get; }

        public Desenvolvedor(string nome, double salario, string linguagem)
            : base(nome, salario)
        {
            Linguagem = linguagem;
        }

        public override void Aceitar(IRelatorioVisitor visitor)
        {
            visitor.GerarRelatorio(this);
        }
    }
}
