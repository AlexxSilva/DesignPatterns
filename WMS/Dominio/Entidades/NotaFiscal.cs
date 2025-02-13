using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Entidades
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public string NumeroNota { get; set; } = string.Empty;
        public DateTime Emissao { get; set; }
        public List<NotaFiscalItem> Itens { get; set; } = new();
    }
}
