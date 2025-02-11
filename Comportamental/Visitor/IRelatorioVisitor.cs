using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Visitor
{
    public interface IRelatorioVisitor
    {
        void GerarRelatorio(Desenvolvedor desenvolvedor);
        void GerarRelatorio(Gerente gerente);
    }
}
