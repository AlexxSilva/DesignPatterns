using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Bridge
{
    public class EntregaFactory
    {
        public static Entrega CriarEntrega(string tipoEntrega, string meioTransporte)
        {
            ITransportadora transportadora;

            switch (meioTransporte.ToLower())
            {
                case "caminhao":
                    transportadora = new Caminhao();
                    break;
                case "navio":
                    transportadora = new Navio();
                    break;
                case "aviao":
                    transportadora = new Aviao();
                    break;
                default:
                    throw new ArgumentException("Transporte inválido");
            }

            switch (tipoEntrega.ToLower())
            {
                case "expressa":
                    return new EntregaExpressa(transportadora);
                case "padrao":
                    return new EntregaPadrao(transportadora);
                default:
                    throw new ArgumentException("Tipo de entrega inválido");
            }
        }

    }
}
