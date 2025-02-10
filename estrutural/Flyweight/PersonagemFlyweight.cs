using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Flyweight
{
    public class PersonagemFlyweight
    {
        public string Tipo { get; private set; }
        public string Sprite { get; private set; }

        public PersonagemFlyweight(string tipo, string sprite)
        {
            Tipo = tipo;
            Sprite = sprite;
        }

        public void Exibir(string nome, int posX, int posY)
        {
            Console.WriteLine($"Exibindo {nome} ({Tipo}) na posição ({posX}, {posY}) com sprite {Sprite}.");
        }
    }
}
