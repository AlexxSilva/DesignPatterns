using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Entidades
{
    public class NotaFiscalItem
    {
        public int Id { get; set; }
        public int NotaFiscalId { get; set; }
        public int ProdutoId { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public List<Lote> Lotes { get; set; } = new();
    }
}
