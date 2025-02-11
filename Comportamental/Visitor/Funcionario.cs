using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Visitor
{
    public abstract class Funcionario
    {
        public string Nome { get; }
        public double Salario { get; }

        protected Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public abstract void Aceitar(IRelatorioVisitor visitor);
    }

}
