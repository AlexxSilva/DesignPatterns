using DesignPatterns.estrutural.decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.Comportamental.State
{
    public class Explicacao
    {
        //O padrão State é um padrão comportamental que permite que um
        //objeto altere seu comportamento quando seu estado interno muda.
        //Em vez de usar condicionais (if-else ou switch), cada estado é
        //encapsulado em uma classe separada, tornando o código mais
        //organizado e manutenível.


        // Imagine uma máquina de café com três estados:
        // Sem Moeda → O usuário precisa inserir uma moeda. 
        // Com Moeda → O usuário pode selecionar o café.
        // Preparando Café → A máquina está preparando o café e voltará ao estado inicial depois.
        // Cada um desses estados terá um comportamento diferente e será implementado como uma classe separada.
    }
}
