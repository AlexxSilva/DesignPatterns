using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace DesignPatterns.estrutural.Adaptador
{
    internal class AdaptadorXMLParaJSON : IProcessadorXML
    {
        private readonly ProcessadorJSON _processadorJSON;

        public AdaptadorXMLParaJSON(ProcessadorJSON processadorJSON)
        {
            _processadorJSON = processadorJSON;
        }

        public void ProcessarXML(string xml)
        {
            Console.WriteLine("🔄 Convertendo XML para JSON...");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string json = JsonSerializer.Serialize(doc.DocumentElement.InnerText);

            _processadorJSON.ProcessarJSON(json);
        }
    }
}
