using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.composite
{
    public class Arquivo : ComponenteSistemaArquivos
    {
        public Arquivo(string nome) : base(nome)
        {
        }

        public override void Exibir(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + Nome);
        }
    }
}
