using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Visitor
{
    public class Gerente : Funcionario
    {
        public int NumeroDeProjetos { get; }

        public Gerente(string nome, double salario, int numeroDeProjetos)
            : base(nome, salario)
        {
            NumeroDeProjetos = numeroDeProjetos;
        }

        public override void Aceitar(IRelatorioVisitor visitor)
        {
            visitor.GerarRelatorio(this);
        }
    }

}
