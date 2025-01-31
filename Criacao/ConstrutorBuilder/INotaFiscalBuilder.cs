using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.ConstrutorBuilder
{
    public interface INotaFiscalBuilder
    {
        INotaFiscalBuilder SetNumero(string numero);
        INotaFiscalBuilder SetDataEmissao(DateTime dataEmissao);
        INotaFiscalBuilder SetEmitente(string emitente);
        INotaFiscalBuilder SetDestinatario(string destinatario);
        INotaFiscalBuilder AdicionarItem(string descricao, int quantidade, decimal valorUnitario);
        NotaFiscal Build();
    }
}
