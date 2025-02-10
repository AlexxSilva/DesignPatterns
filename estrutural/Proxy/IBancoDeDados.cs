using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Proxy
{
    public interface IBancoDeDados
    {
        void ConsultarDados(string usuario);
    }
}
