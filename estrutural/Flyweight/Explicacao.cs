using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.estrutural.Flyweight
{
    public class Explicacao
    {
        //Imagine que estamos desenvolvendo um jogo onde há milhares de personagens,
        //mas muitos compartilham os mesmos atributos (como sprite e animações).
        //O Flyweight permite compartilhar esses dados entre os personagens para
        //reduzir o uso de memória.

        //Os personagens "Arthur" e "Lancelot" compartilham o mesmo objeto
        //PersonagemFlyweight do tipo "Guerreiro"

        //Apenas um objeto é criado para representar todos os guerreiros.

        //O mesmo ocorre com Merlin, que compartilha um objeto do tipo "Mago".

        //Cada personagem tem um estado único, como nome e posição

        //Se tivéssemos criado um objeto completo para cada personagem, o
        //consumo de memória seria maior.
    }
}
