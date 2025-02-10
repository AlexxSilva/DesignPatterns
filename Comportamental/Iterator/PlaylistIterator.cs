using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Iterator
{
    public class PlaylistIterator : IIterator
    {
        private Playlist _playlist;
        private int _posicaoAtual = 0;

        public PlaylistIterator(Playlist playlist)
        {
            _playlist = playlist;
        }

        // Verifica se há mais músicas na playlist
        public bool TemProximo()
        {
            return _posicaoAtual < _playlist.QuantidadeMusicas;
        }

        // Retorna a próxima música da playlist
        public object Proximo()
        {
            Musica musica = _playlist.ObterMusica(_posicaoAtual);
            _posicaoAtual++;
            return musica;
        }
    }
}
