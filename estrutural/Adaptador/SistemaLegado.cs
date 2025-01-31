using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Adaptador
{
    public class SistemaLegado
    {
        private readonly IProcessadorXML _processadorXML;

        public SistemaLegado(IProcessadorXML processadorXML)
        {
            _processadorXML = processadorXML;
        }
        public void Executar()
        {
            string xml = "<dados><nome>Alex</nome><idade>30</idade></dados>";
            Console.WriteLine("📄 Enviando XML para processamento...");
            _processadorXML.ProcessarXML(xml);
        }

    }
}
