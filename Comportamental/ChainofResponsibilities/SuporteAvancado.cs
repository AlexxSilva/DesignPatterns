using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.ChainofResponsibilities
{
    class SuporteAvancado : Suporte
    {
        public override void TratarChamado(string problema)
        {
            Console.WriteLine("[Suporte Avançado] Investigando problema crítico: " + problema);
        }
    }
}
