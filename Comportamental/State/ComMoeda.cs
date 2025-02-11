using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.State
{
    public class ComMoeda : IEstadoMaquinaCafe
    {
        private readonly MaquinaCafe _maquina;

        public ComMoeda(MaquinaCafe maquina)
        {
            _maquina = maquina;
        }

        public void InserirMoeda()
        {
            Console.WriteLine("Já existe uma moeda inserida.");
        }

        public void SelecionarCafe()
        {
            Console.WriteLine("Café selecionado. Preparando...");
            _maquina.DefinirEstado(_maquina.EstadoPreparando);
        }

        public void PrepararCafe()
        {
            Console.WriteLine("Escolha um café primeiro!");
        }
    }
}
