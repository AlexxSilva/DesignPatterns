using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Proxy
{
    public class BancoProxy: IBancoDeDados
    {
        private BancoDeDados _bancoReal;
        private List<string> _usuariosPermitidos;

        public BancoProxy()
        {
            _bancoReal = new BancoDeDados();
            _usuariosPermitidos = new List<string> { "admin", "gestor" }; // Apenas esses usuários podem acessar
        }

        public void ConsultarDados(string usuario)
        {
            if (_usuariosPermitidos.Contains(usuario.ToLower()))
            {
                Console.WriteLine($"[Proxy] Acesso permitido para {usuario}. Redirecionando ao banco...");
                _bancoReal.ConsultarDados(usuario);
            }
            else
            {
                Console.WriteLine($"[Proxy] Acesso negado para {usuario}.");
            }
        }
    }
}
