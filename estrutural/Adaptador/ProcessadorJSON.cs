using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Adaptador
{
    public class ProcessadorJSON
    {
        public void ProcessarJSON(string json)
        {
            Console.WriteLine("Processando dados JSON...");
            Console.WriteLine(json);
        }
    }
}
