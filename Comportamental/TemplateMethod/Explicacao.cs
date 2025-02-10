using DesignPatterns.estrutural.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.TemplateMethod
{
    public class Explicacao
    {
        //O Template Method é um padrão comportamental que define a estrutura de um
        //algoritmo na classe base, permitindo que subclasses implementem partes
        //específicas sem alterar a estrutura principal.


        //Vamos criar um modelo para processamento de pagamentos usando o Template Method.
        //Suponha que temos diferentes formas de pagamento, como cartão de crédito e PayPal,
        //mas todas seguem um fluxo geral:

        //Validar os dados do pagamento.
        //Processar o pagamento.
        //Enviar confirmação.
        //Cada método de pagamento terá sua própria implementação do processamento, mas
        //seguirá os mesmos passos.

        //O método Processar() define a sequência de passos do pagamento.
        //ValidarDados() e AutorizarPagamento() são específicos para cada forma de pagamento.

       // ConfirmarPagamento() é um método virtual, permitindo que as subclasses o substituam se necessário.
    }
}
