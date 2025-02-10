using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.ChainofResponsibilities
{
    class SuporteIntermediario : Suporte
    {
        public override void TratarChamado(string problema)
        {
            if (problema.Contains("software") || problema.Contains("instalação"))
            {
                Console.WriteLine("[Suporte Intermediário] Problema resolvido: " + problema);
            }
            else if (_proximoNivel != null)
            {
                Console.WriteLine("[Suporte Intermediário] Encaminhando para nível superior...");
                _proximoNivel.TratarChamado(problema);
            }
        }
    }
}
