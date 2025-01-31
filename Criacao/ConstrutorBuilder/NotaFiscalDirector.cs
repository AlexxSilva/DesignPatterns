using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.ConstrutorBuilder
{
    public class NotaFiscalDirector
    {
        private readonly INotaFiscalBuilder _builder;
        public NotaFiscalDirector(INotaFiscalBuilder builder)
        {
            _builder = builder;
        }

        public void ConstruirNotaFiscalBasica()
        {
            _builder.SetNumero("12345")
                    .SetDataEmissao(DateTime.Now)
                    .SetEmitente("Empresa XYZ")
                    .SetDestinatario("Cliente ABC");
        }

        public void ConstruirNotaFiscalCompleta()
        {
            _builder.SetNumero("12345")
                    .SetDataEmissao(DateTime.Now)
                    .SetEmitente("Empresa XYZ")
                    .SetDestinatario("Cliente ABC")
                    .AdicionarItem("Produto A", 2, 100.00m)
                    .AdicionarItem("Produto B", 1, 200.00m);
        }
    }
}
