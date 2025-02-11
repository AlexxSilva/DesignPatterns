using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Mediator
{
    public class UsuarioConcreto : Usuario
    {
        public UsuarioConcreto(IMediadorChat mediador, string nome) : base(mediador, nome) { }

        public override void ReceberMensagem(string mensagem, Usuario remetente)
        {
            Console.WriteLine($"{Nome} recebeu de {remetente.Nome}: {mensagem}");
        }
    }
}
