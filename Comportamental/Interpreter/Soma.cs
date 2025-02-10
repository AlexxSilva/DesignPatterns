using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Interpreter
{
    public class Soma : IExpressao
    {
        private IExpressao _esquerda, _direita;

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public int Interpretar()
        {
            return _esquerda.Interpretar() + _direita.Interpretar();
        }
    }
}
