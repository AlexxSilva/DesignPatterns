using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Entidades
{

    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Prateleira { get; set; }
        public string Nivel { get; set; }
        public bool Ocupado { get; set; }

        public Endereco(int id, string rua, string prateleira, string nivel, bool ocupado)
        {
            this.Id = id;
            this.Rua = rua;
            this.Prateleira = prateleira;
            this.Nivel = nivel;
            this.Ocupado = ocupado;
        }

    }
}
