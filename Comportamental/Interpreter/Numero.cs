using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Interpreter
{

    public class Numero : IExpressao
    {
        private int _valor;

        public Numero(int valor)
        {
            _valor = valor;
        }

        public int Interpretar()
        {
            return _valor;
        }
    }

}
