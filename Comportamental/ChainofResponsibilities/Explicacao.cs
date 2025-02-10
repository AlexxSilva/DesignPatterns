using DesignPatterns.estrutural.composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.ChainofResponsibilities
{
    public class Explicacao
    {
        //O Chain of Responsibility(Corrente de Responsabilidade) é um padrão
        //comportamental que permite passar uma solicitação ao longo de uma
        //cadeia de manipuladores, onde cada um pode processá-la ou passá-la adiante.

        //Vamos criar um sistema de suporte onde os chamados passam por diferentes níveis de atendimento:

        //Suporte Básico – Resolve problemas simples.
        //Suporte Intermediário – Resolve problemas mais técnicos.
        //Suporte Avançado – Apenas para problemas críticos.
        //Se um nível não consegue resolver, ele passa a solicitação para o próximo.
    }
}
