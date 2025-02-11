using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.State
{
    public class SemMoeda : IEstadoMaquinaCafe
    {
        private readonly MaquinaCafe _maquina;

        public SemMoeda(MaquinaCafe maquina)
        {
            _maquina = maquina;
        }

        public void InserirMoeda()
        {
            Console.WriteLine("Moeda inserida. Agora você pode escolher o café.");
            _maquina.DefinirEstado(_maquina.EstadoComMoeda);
        }

        public void SelecionarCafe()
        {
            Console.WriteLine("Insira uma moeda primeiro!");
        }

        public void PrepararCafe()
        {
            Console.WriteLine("Você precisa pagar antes de preparar o café.");
        }
    }
}
