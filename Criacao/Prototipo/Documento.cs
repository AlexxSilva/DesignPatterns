using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.Prototipo
{
    public class Documento : IPrototype<Documento>
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public List<string> Autores { get; set; }

        public Documento(string titulo, string conteudo, List<string> autores)
        {
            Titulo = titulo;
            Conteudo = conteudo;
            Autores = new List<string>(autores); 
        }

        public Documento Clone()
        {
            return new Documento(Titulo, Conteudo, new List<string>(Autores));
        }

        public void Exibir()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Conteúdo: {Conteudo}");
            Console.WriteLine("Autores:");
            foreach (var autor in Autores)
            {
                Console.WriteLine($" - {autor}");
            }
            Console.WriteLine();
        }
    }
}
