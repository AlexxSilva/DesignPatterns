using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Unidade { get; set; } = string.Empty;
        public decimal QtdeTotal { get; set; }
        public decimal QuantidadeMinima { get; set; } = 10;
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
