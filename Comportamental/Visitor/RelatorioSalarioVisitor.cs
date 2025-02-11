using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Visitor
{
    public class RelatorioSalarioVisitor : IRelatorioVisitor
    {
        public void GerarRelatorio(Desenvolvedor desenvolvedor)
        {
            Console.WriteLine($" Relatório Desenvolvedor: {desenvolvedor.Nome}, " +
                              $"Salário: R${desenvolvedor.Salario:F2}, " +
                              $"Linguagem: {desenvolvedor.Linguagem}");
        }

        public void GerarRelatorio(Gerente gerente)
        {
            Console.WriteLine($"Relatório Gerente: {gerente.Nome}, " +
                              $"Salário: R${gerente.Salario:F2}, " +
                              $"Projetos Gerenciados: {gerente.NumeroDeProjetos}");
        }
    }
}
