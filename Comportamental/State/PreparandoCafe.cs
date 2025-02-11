using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.State
{
    public class PreparandoCafe : IEstadoMaquinaCafe
    {
        private readonly MaquinaCafe _maquina;

        public PreparandoCafe(MaquinaCafe maquina)
        {
            _maquina = maquina;
        }

        public void InserirMoeda()
        {
            Console.WriteLine("Aguarde! O café já está sendo preparado.");
        }

        public void SelecionarCafe()
        {
            Console.WriteLine("Aguarde! O café está quase pronto.");
        }

        public void PrepararCafe()
        {
            Console.WriteLine("Café pronto! Pegue seu café.");
            _maquina.DefinirEstado(_maquina.EstadoSemMoeda);
        }
    }
}
