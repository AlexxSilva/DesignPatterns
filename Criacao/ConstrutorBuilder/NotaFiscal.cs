using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.ConstrutorBuilder
{
    public class NotaFiscal
    {
        public string Numero { get; set; } 
        public DateTime DataEmissao { get; set; }
        public string Emitente { get; set; }
        public string Destinatario {  get; set; }
        public decimal ValorTotal { get; set; }

        public List<ItemNota> Itens { get; set; } = new List<ItemNota>();


        public void Exibir()
        {
            Console.WriteLine($"Nota Fiscal: {Numero}");
            Console.WriteLine($"Data de Emissão: {DataEmissao}");
            Console.WriteLine($"Emitente: {Emitente}");
            Console.WriteLine($"Destinatário: {Destinatario}");
            Console.WriteLine("Itens:");
            foreach (var item in Itens)
            {
                Console.WriteLine($"  - {item.Descricao}: {item.Quantidade} x {item.ValorUnitario:C} = {item.ValorTotal:C}");
            }
            Console.WriteLine($"Valor Total: {ValorTotal:C}");
        }
    }
}
