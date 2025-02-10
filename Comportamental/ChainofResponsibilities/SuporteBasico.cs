using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.ChainofResponsibilities
{
    class SuporteBasico : Suporte
    {
        public override void TratarChamado(string problema)
        {
            if (problema.Contains("senha") || problema.Contains("rede"))
            {
                Console.WriteLine("[Suporte Básico] Problema resolvido: " + problema);
            }
            else if (_proximoNivel != null)
            {
                Console.WriteLine("[Suporte Básico] Encaminhando para nível superior...");
                _proximoNivel.TratarChamado(problema);
            }
        }
    }
}
