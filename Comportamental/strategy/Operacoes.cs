using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.strategy
{
    public class Adicao : IOperacao
    {
        public double Calcular(double a, double b) => a + b;
    }

    public class Subtracao : IOperacao
    {
        public double Calcular(double a, double b) => a - b;
    }

    public class Multiplicacao : IOperacao
    {
        public double Calcular(double a, double b) => a * b;
    }

    public class Calculadora
    {
        private IOperacao _operacao;

        public void DefinirOperacao(IOperacao operacao)
        {
            _operacao = operacao;
        }

        public double ExecutarCalculo(double a, double b)
        {
            return _operacao.Calcular(a, b);
        }
    }

}
