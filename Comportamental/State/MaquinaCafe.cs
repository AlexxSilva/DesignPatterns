using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.State
{
    public class MaquinaCafe
    {
        public IEstadoMaquinaCafe EstadoSemMoeda { get; }
        public IEstadoMaquinaCafe EstadoComMoeda { get; }
        public IEstadoMaquinaCafe EstadoPreparando { get; }

        private IEstadoMaquinaCafe _estadoAtual;

        public MaquinaCafe()
        {
            EstadoSemMoeda = new SemMoeda(this);
            EstadoComMoeda = new ComMoeda(this);
            EstadoPreparando = new PreparandoCafe(this);

            _estadoAtual = EstadoSemMoeda; // Estado inicial
        }

        public void DefinirEstado(IEstadoMaquinaCafe novoEstado)
        {
            _estadoAtual = novoEstado;
        }

        public void InserirMoeda()
        {
            _estadoAtual.InserirMoeda();
        }

        public void SelecionarCafe()
        {
            _estadoAtual.SelecionarCafe();
        }

        public void PrepararCafe()
        {
            _estadoAtual.PrepararCafe();
        }
    }

}
