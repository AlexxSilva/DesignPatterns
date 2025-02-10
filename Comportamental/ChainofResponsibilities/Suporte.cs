using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.ChainofResponsibilities
{
    public abstract class Suporte
    {
        protected Suporte _proximoNivel;

        public void DefinirProximoNivel(Suporte proximo)
        {
            _proximoNivel = proximo;
        }

        public abstract void TratarChamado(string problema);
    }
}
