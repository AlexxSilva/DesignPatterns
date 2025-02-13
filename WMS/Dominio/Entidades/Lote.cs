using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Entidades
{
    public class Lote
    {
        public int Id { get; set; }
        public int NotaFiscalItemId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public string NumeroLote { get; set; } = string.Empty;
        public int EnderecoId { get; set; }
    }
}
