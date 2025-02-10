using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Flyweight
{
    public class PersonagemFactory
    {
        private Dictionary<string, PersonagemFlyweight> _personagens = new();

        public PersonagemFlyweight GetPersonagem(string tipo)
        {
            if (!_personagens.ContainsKey(tipo))
            {
                // Criando um novo personagem caso ainda não exista
                Console.WriteLine($"Criando novo personagem do tipo: {tipo}");

                string sprite = $"Sprite_{tipo}.png"; // Simulação de um sprite
                _personagens[tipo] = new PersonagemFlyweight(tipo, sprite);
            }

            return _personagens[tipo];
        }
    }
}
