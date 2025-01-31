using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.ConstrutorBuilder
{
    public class NotaFiscalBuilder : INotaFiscalBuilder
    {
        private NotaFiscal _notaFiscal = new NotaFiscal();

        public INotaFiscalBuilder SetNumero(string numero)
        {
            _notaFiscal.Numero = numero;
            return this;
        }

        public INotaFiscalBuilder SetDataEmissao(DateTime dataEmissao)
        {
            _notaFiscal.DataEmissao = dataEmissao;
            return this;
        }

        public INotaFiscalBuilder SetEmitente(string emitente)
        {
            _notaFiscal.Emitente = emitente;
            return this;
        }

        public INotaFiscalBuilder SetDestinatario(string destinatario)
        {
            _notaFiscal.Destinatario = destinatario;
            return this;
        }

        public INotaFiscalBuilder AdicionarItem(string descricao, int quantidade, decimal valorUnitario)
        {
            var item = new ItemNota
            {
                Descricao = descricao,
                Quantidade = quantidade,
                ValorUnitario = valorUnitario
            };
            _notaFiscal.Itens.Add(item);
            _notaFiscal.ValorTotal += item.ValorTotal;
            return this;
        }

        public NotaFiscal Build()
        {
            return _notaFiscal;
        }
    }
}
