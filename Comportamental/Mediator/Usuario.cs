using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Mediator
{
    public abstract class Usuario
    {
        protected IMediadorChat _mediador;
        public string Nome { get; }

        public Usuario(IMediadorChat mediador, string nome)
        {
            _mediador = mediador;
            Nome = nome;
        }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"{Nome} enviando mensagem: {mensagem}");
            _mediador.EnviarMensagem(mensagem, this);
        }

        public abstract void ReceberMensagem(string mensagem, Usuario remetente);
    }
}
