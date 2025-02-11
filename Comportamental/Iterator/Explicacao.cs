using DesignPatterns.Comportamental.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Comportamental.Iterator
{
    public class Explicacao
    {
        //O padrao é usado para fornecer uma maneira de acessar elementos de um agregado
        //(como listas, coleções ou conjuntos) sequencialmente, sem expor sua estrutura interna.

        //Imagine que um restaurante tem um sistema onde o garçom pode percorrer os pedidos
        //pendentes um por um.Para isso, usamos o Iterator para percorrer a lista de pedidos
        //sem expor diretamente a estrutura da coleção.

        //Encapsulamento → A estrutura interna da coleção(Lista) não é exposta.

        //Podemos mudar a implementação da coleção sem impactar quem a usa.

        // navegação pelos pedidos é separada da lógica principal.Esse exemplo mostra como o
        // Iterator pode ser aplicado em sistemas reais, tornando o código mais organizado e desacoplado
    }
}
