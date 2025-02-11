using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Mediator
{
    public interface IMediadorChat
    {
        void EnviarMensagem(string mensagem, Usuario usuario);
        void RegistrarUsuario(Usuario usuario);
    }
}
