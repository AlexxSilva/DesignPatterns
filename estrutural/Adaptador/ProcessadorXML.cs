using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DesignPatterns.estrutural.Adaptador
{
    public class ProcessadorXML : IProcessadorXML
    {
        public void ProcessarXML(string xml)
        {
            Console.WriteLine("Processando XML diretamente...");
        }
    }
}
