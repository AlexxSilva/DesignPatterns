using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Mediator
{
    public class MediadorChat : IMediadorChat
    {
        private readonly List<Usuario> _usuarios = new();

        public void RegistrarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void EnviarMensagem(string mensagem, Usuario usuario)
        {
            foreach (var u in _usuarios)
            {
                // Usuário não recebe sua própria mensagem
                if (u != usuario)
                {
                    u.ReceberMensagem(mensagem, usuario);
                }
            }
        }
    }
}
