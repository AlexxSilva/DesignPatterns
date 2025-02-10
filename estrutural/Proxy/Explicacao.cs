using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Proxy
{
    public class Explicacao
    {
        //Imagine que temos um sistema que acessa informações sensíveis de um banco de dados.
        //Podemos usar um Proxy para verificar permissões antes de permitir o acesso real ao banco.

        //O proxy verifica a permissão do usuário antes de acessar o banco.
        //O banco de dados não é chamado se o usuário não tiver permissão.
        //Podemos modificar o proxy sem alterar o banco de dados real.
    }
}
