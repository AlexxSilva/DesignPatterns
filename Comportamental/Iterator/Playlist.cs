using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Iterator
{
    public class Playlist : IAgregada
    {
        private List<Musica> _musicas = new List<Musica>();

        public void AdicionarMusica(Musica musica)
        {
            _musicas.Add(musica);
        }

        public int QuantidadeMusicas => _musicas.Count;

        public Musica ObterMusica(int indice)
        {
            return _musicas[indice];
        }

        // Implementação do método para criar um Iterator
        public IIterator CriarIterator()
        {
            return new PlaylistIterator(this);
        }
    }
}
