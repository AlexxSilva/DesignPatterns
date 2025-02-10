// See https://aka.ms/new-console-template for more information
using DesignPatterns.Comportamental.ChainofResponsibilities;
using DesignPatterns.Comportamental.Command;
using DesignPatterns.Comportamental.Interpreter;
using DesignPatterns.Comportamental.Iterator;
using DesignPatterns.Comportamental.TemplateMethod;
using DesignPatterns.Criacao.ConstrutorBuilder;
using DesignPatterns.Criacao.Metodofabrica;
using DesignPatterns.Criacao.Singleton;
using DesignPatterns.estrutural.Adaptador;
using DesignPatterns.estrutural.Bridge;
using DesignPatterns.estrutural.composite;
using DesignPatterns.estrutural.decorator;
using DesignPatterns.estrutural.Facade;
using DesignPatterns.estrutural.Flyweight;
using DesignPatterns.estrutural.Proxy;


internal class Program
{
    private static void Main(string[] args)
    {
        //factory method
        IFreteFactory factory = new FreteAereoFactory(10);
        IFrete frete = factory.CriarFrete();
        frete.CalcularFrete();

        //abstract method
        // Usando a Abstract Factory para criar fretes da Transportadora Alpha
        DesignPatterns.Criacao.MetodoAbstrato.ITransportadoraFactory factoryAlpha =
            new DesignPatterns.Criacao.MetodoAbstrato.TransportadoraAlphaFactory();
        Console.WriteLine("Fretes da Transportadora Alpha:");
        DesignPatterns.Criacao.MetodoAbstrato.IFrete freteNavioAlpha = factoryAlpha.CriarFreteNavio();
        freteNavioAlpha.CalcularFrete();


        //builder
        var builder = new NotaFiscalBuilder();
        var director = new NotaFiscalDirector(builder);
        director.ConstruirNotaFiscalBasica();
        var notaFiscalBasica = builder.Build();
        notaFiscalBasica.Exibir();

        // Prototype
        director.ConstruirNotaFiscalCompleta();
        var notaFiscalCompleta = builder.Build();
        notaFiscalCompleta.Exibir();


        // Singleton
        Logger logger = Logger.Instancia;
        logger.Registrar("Aplicação iniciada.");
        logger.Registrar("Operação 1 executada.");
        logger.Registrar("Aplicação finalizada.");

        //Adapter

        ProcessadorJSON processadorJSON = new ProcessadorJSON();
        IProcessadorXML adaptador = new AdaptadorXMLParaJSON(processadorJSON);
        SistemaLegado sistema = new SistemaLegado(adaptador);
        sistema.Executar();


        //bridge
        var pedidos = new List<(string TipoEntrega, string Transporte, string Pacote)>
        {
            ("expressa", "aviao", "Pacote 1"),
            ("padrao", "caminhao", "Pacote 2"),
            ("padrao", "navio", "Pacote 3")
        };

        foreach (var ped in pedidos)
        {
            var entrega = EntregaFactory.CriarEntrega(ped.TipoEntrega, ped.Transporte);
            entrega.ProcessarEntrega(ped.Pacote);
            Console.WriteLine();
        }

        //Composite
        // Cria a estrutura de arquivos
        Pasta raiz = new Pasta("Raiz");
        Pasta pasta1 = new Pasta("Pasta 1");
        Pasta pasta2 = new Pasta("Pasta 2");

        Arquivo arquivo1 = new Arquivo("Arquivo 1.txt");
        Arquivo arquivo2 = new Arquivo("Arquivo 2.txt");
        Arquivo arquivo3 = new Arquivo("Arquivo 3.txt");

        // Adiciona arquivos às pastas
        pasta1.Adicionar(arquivo1);
        pasta1.Adicionar(arquivo2);

        pasta2.Adicionar(arquivo3);

        // Adiciona pastas à raiz
        raiz.Adicionar(pasta1);
        raiz.Adicionar(pasta2);

        // Exibe a estrutura de arquivos
        raiz.Exibir(1);

        //Decorator

        // Cria uma bebida base (café simples)
        Bebida bebida = new Cafe();
        Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        // Adiciona leite ao café
        bebida = new Leite(bebida);
        Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        // Adiciona chantilly ao café com leite
        bebida = new Chantilly(bebida);
        Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        // Adiciona chocolate ao café com leite e chantilly
        bebida = new Chocolate(bebida);
        Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        //iterator
        // Cria a playlist e adiciona músicas
        Playlist playlist = new Playlist();
        playlist.AdicionarMusica(new Musica("Bohemian Rhapsody"));
        playlist.AdicionarMusica(new Musica("Stairway to Heaven"));
        playlist.AdicionarMusica(new Musica("Hotel California"));

        // Cria o Iterator para percorrer a playlist
        IIterator iterator = playlist.CriarIterator();

        // Percorre a playlist usando o Iterator
        Console.WriteLine("Músicas na playlist:");
        while (iterator.TemProximo())
        {
            Musica musica = (Musica)iterator.Proximo();
            Console.WriteLine(musica.Nome);
        }

        //facade
        PedidoFacade pedido = new PedidoFacade();

        // Cliente faz um pedido sem precisar interagir com os subsistemas
        pedido.FazerPedido("Notebook", "1234-5678-9012-3456", "cliente@email.com");


        //Flyweight

        PersonagemFactory fac = new PersonagemFactory();

        // Criando personagens com estado compartilhado (Flyweight)
        var guerreiro1 = fac.GetPersonagem("Guerreiro");
        var guerreiro2 = fac.GetPersonagem("Guerreiro");
        var mago1 = fac.GetPersonagem("Mago");

        // Definindo estados únicos para cada instância (posição e nome)
        guerreiro1.Exibir("Arthur", 10, 20);
        guerreiro2.Exibir("Lancelot", 15, 25);
        mago1.Exibir("Merlin", 5, 30);


        //Proxy

        IBancoDeDados banco = new BancoProxy();

        banco.ConsultarDados("admin");  // Deve permitir
        banco.ConsultarDados("gestor"); // Deve permitir
        banco.ConsultarDados("cliente"); // Deve bloquear

        //Interpreter
        IExpressao expressao = new Soma(new Numero(10), new Numero(5));
        Console.WriteLine($"Resultado da expressão: {expressao.Interpretar()}");

        //Template Method

        Console.WriteLine("=== Pagamento com Cartão de Crédito ===");
        DesignPatterns.Comportamental.TemplateMethod.Pagamento pagamento1 = new PagamentoCartaoCredito();
        pagamento1.Processar();

        Console.WriteLine("=== Pagamento com PayPal ===");
        DesignPatterns.Comportamental.TemplateMethod.Pagamento pagamento2 = new PagamentoPayPal();
        pagamento2.Processar();


        //ChainOfResponsabilities
        // Criando os níveis de suporte
        Suporte suporteBasico = new SuporteBasico();
        Suporte suporteIntermediario = new SuporteIntermediario();
        Suporte suporteAvancado = new SuporteAvancado();

        // Configurando a corrente
        suporteBasico.DefinirProximoNivel(suporteIntermediario);
        suporteIntermediario.DefinirProximoNivel(suporteAvancado);

        // Testando chamados
        Console.WriteLine("Chamado 1: Problema com senha.");
        suporteBasico.TratarChamado("Esqueci minha senha");

        Console.WriteLine("\nChamado 2: Falha ao instalar um software.");
        suporteBasico.TratarChamado("Erro ao instalar o software");

        Console.WriteLine("\nChamado 3: Servidor caiu.");
        suporteBasico.TratarChamado("Servidor fora do ar");

        //Command

        // Criando os setores do restaurante
        Cozinha cozinha = new Cozinha();
        Bar bar = new Bar();

        // Criando pedidos
        IPedido pedido1 = new PedidoComida(cozinha, "Pizza");
        IPedido pedido2 = new PedidoBebida(bar, "Caipirinha");

        // Criando o garçom
        Garcom garcom = new Garcom();

        // Adicionando pedidos
        garcom.AdicionarPedido(pedido1);
        garcom.AdicionarPedido(pedido2);

        // Processando os pedidos
        garcom.ProcessarPedidos();

        // Cancelando um pedido
        Console.WriteLine("\nCancelando o último pedido...");
        garcom.CancelarUltimoPedido();


    }
}