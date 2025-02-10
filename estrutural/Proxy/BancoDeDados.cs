using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Proxy
{
    public class BancoDeDados : IBancoDeDados
    {
        public void ConsultarDados(string usuario)
        {
            Console.WriteLine($"[Banco] Consultando dados para o usuário: {usuario}");
        }
    }
}
