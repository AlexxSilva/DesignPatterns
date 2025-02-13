// See https://aka.ms/new-console-template for more information
using DesignPatterns.Comportamental.ChainofResponsibilities;
using DesignPatterns.Comportamental.Command;
using DesignPatterns.Comportamental.Interpreter;
using DesignPatterns.Comportamental.Iterator;
using DesignPatterns.Comportamental.Mediator;
using DesignPatterns.Comportamental.Memento;
using DesignPatterns.Comportamental.Observer;
using DesignPatterns.Comportamental.State;
using DesignPatterns.Comportamental.strategy;
using DesignPatterns.Comportamental.TemplateMethod;
using DesignPatterns.Comportamental.Visitor;
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
using DesignPatterns.WMS.Aplicacao.Decorators;
using DesignPatterns.WMS.Aplicacao.Factories;
using DesignPatterns.WMS.Aplicacao.Observers;
using DesignPatterns.WMS.Aplicacao.Services;
using DesignPatterns.WMS.Aplicacao.Strategies;
using DesignPatterns.WMS.Dominio.Entidades;
using DesignPatterns.WMS.Dominio.Interfaces;
using DesignPatterns.WMS.Infraestrutura;


internal class Program
{
    private static void Main(string[] args)
    {
        ////factory method ---------------------------------------------------------
        //IFreteFactory factory = new FreteAereoFactory(10);
        //IFrete frete = factory.CriarFrete();
        //frete.CalcularFrete();

        ////abstract method ---------------------------------------------------------
        //// Usando a Abstract Factory para criar fretes da Transportadora Alpha
        //DesignPatterns.Criacao.MetodoAbstrato.ITransportadoraFactory factoryAlpha =
        //    new DesignPatterns.Criacao.MetodoAbstrato.TransportadoraAlphaFactory();
        //Console.WriteLine("Fretes da Transportadora Alpha:");
        //DesignPatterns.Criacao.MetodoAbstrato.IFrete freteNavioAlpha = factoryAlpha.CriarFreteNavio();
        //freteNavioAlpha.CalcularFrete();


        ////builder ---------------------------------------------------------
        //var builder = new NotaFiscalBuilder();
        //var director = new NotaFiscalDirector(builder);
        //director.ConstruirNotaFiscalBasica();
        //var notaFiscalBasica = builder.Build();
        //notaFiscalBasica.Exibir();

        //// Prototype ---------------------------------------------------------
        //director.ConstruirNotaFiscalCompleta();
        //var notaFiscalCompleta = builder.Build();
        //notaFiscalCompleta.Exibir();


        //// Singleton ---------------------------------------------------------
        //Logger logger = Logger.Instancia;
        //logger.Registrar("Aplicação iniciada.");
        //logger.Registrar("Operação 1 executada.");
        //logger.Registrar("Aplicação finalizada.");

        ////Adapter ---------------------------------------------------------

        //ProcessadorJSON processadorJSON = new ProcessadorJSON();
        //IProcessadorXML adaptador = new AdaptadorXMLParaJSON(processadorJSON);
        //SistemaLegado sistema = new SistemaLegado(adaptador);
        //sistema.Executar();


        ////bridge ---------------------------------------------------------
        //var pedidos = new List<(string TipoEntrega, string Transporte, string Pacote)>
        //{
        //    ("expressa", "aviao", "Pacote 1"),
        //    ("padrao", "caminhao", "Pacote 2"),
        //    ("padrao", "navio", "Pacote 3")
        //};

        //foreach (var ped in pedidos)
        //{
        //    var entrega = EntregaFactory.CriarEntrega(ped.TipoEntrega, ped.Transporte);
        //    entrega.ProcessarEntrega(ped.Pacote);
        //    Console.WriteLine();
        //}

        ////Composite ---------------------------------------------------------
        //// Cria a estrutura de arquivos
        //Pasta raiz = new Pasta("Raiz");
        //Pasta pasta1 = new Pasta("Pasta 1");
        //Pasta pasta2 = new Pasta("Pasta 2");

        //Arquivo arquivo1 = new Arquivo("Arquivo 1.txt");
        //Arquivo arquivo2 = new Arquivo("Arquivo 2.txt");
        //Arquivo arquivo3 = new Arquivo("Arquivo 3.txt");

        //// Adiciona arquivos às pastas
        //pasta1.Adicionar(arquivo1);
        //pasta1.Adicionar(arquivo2);

        //pasta2.Adicionar(arquivo3);

        //// Adiciona pastas à raiz
        //raiz.Adicionar(pasta1);
        //raiz.Adicionar(pasta2);

        //// Exibe a estrutura de arquivos
        //raiz.Exibir(1);

        ////Decorator ---------------------------------------------------------

        //// Cria uma bebida base (café simples)
        //Bebida bebida = new Cafe();
        //Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        //// Adiciona leite ao café
        //bebida = new Leite(bebida);
        //Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        //// Adiciona chantilly ao café com leite
        //bebida = new Chantilly(bebida);
        //Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        //// Adiciona chocolate ao café com leite e chantilly
        //bebida = new Chocolate(bebida);
        //Console.WriteLine($"{bebida.Descricao} - Custo: R${bebida.Custo()}");

        ////iterator ---------------------------------------------------------

        //var listaPedidos = new ListaPedidos();

        //// Adicionando alguns pedidos ao sistema
        //listaPedidos.AdicionarPedido(new Pedido(1, "Carlos", "Pizza de Calabresa"));
        //listaPedidos.AdicionarPedido(new Pedido(2, "Ana", "Lasanha à Bolonhesa"));
        //listaPedidos.AdicionarPedido(new Pedido(3, "João", "Hambúrguer Artesanal"));

        //// Criando o iterador para percorrer os pedidos
        //var iterador = listaPedidos.CriarIterador();

        //Console.WriteLine("PEDIDOS PENDENTES:");
        //while (iterador.TemProximo())
        //{
        //    Console.WriteLine(iterador.Proximo());
        //}


        ////facade ---------------------------------------------------------
        //PedidoFacade pedido = new PedidoFacade();

        //// Cliente faz um pedido sem precisar interagir com os subsistemas
        //pedido.FazerPedido("Notebook", "1234-5678-9012-3456", "cliente@email.com");


        ////Flyweight ---------------------------------------------------------

        //PersonagemFactory fac = new PersonagemFactory();

        //// Criando personagens com estado compartilhado (Flyweight)
        //var guerreiro1 = fac.GetPersonagem("Guerreiro");
        //var guerreiro2 = fac.GetPersonagem("Guerreiro");
        //var mago1 = fac.GetPersonagem("Mago");

        //// Definindo estados únicos para cada instância (posição e nome)
        //guerreiro1.Exibir("Arthur", 10, 20);
        //guerreiro2.Exibir("Lancelot", 15, 25);
        //mago1.Exibir("Merlin", 5, 30);


        ////Proxy ---------------------------------------------------------

        //IBancoDeDados banco = new BancoProxy();

        //banco.ConsultarDados("admin");  // Deve permitir
        //banco.ConsultarDados("gestor"); // Deve permitir
        //banco.ConsultarDados("cliente"); // Deve bloquear

        ////Interpreter ---------------------------------------------------------
        //IExpressao expressao = new Soma(new Numero(10), new Numero(5));
        //Console.WriteLine($"Resultado da expressão: {expressao.Interpretar()}");

        ////Template Method ---------------------------------------------------------

        //Console.WriteLine("=== Pagamento com Cartão de Crédito ===");
        //DesignPatterns.Comportamental.TemplateMethod.Pagamento pagamento1 = new PagamentoCartaoCredito();
        //pagamento1.Processar();

        //Console.WriteLine("=== Pagamento com PayPal ===");
        //DesignPatterns.Comportamental.TemplateMethod.Pagamento pagamento2 = new PagamentoPayPal();
        //pagamento2.Processar();


        ////ChainOfResponsabilities ---------------------------------------------------------
        //// Criando os níveis de suporte
        //Suporte suporteBasico = new SuporteBasico();
        //Suporte suporteIntermediario = new SuporteIntermediario();
        //Suporte suporteAvancado = new SuporteAvancado();

        //// Configurando a corrente
        //suporteBasico.DefinirProximoNivel(suporteIntermediario);
        //suporteIntermediario.DefinirProximoNivel(suporteAvancado);

        //// Testando chamados
        //Console.WriteLine("Chamado 1: Problema com senha.");
        //suporteBasico.TratarChamado("Esqueci minha senha");

        //Console.WriteLine("\nChamado 2: Falha ao instalar um software.");
        //suporteBasico.TratarChamado("Erro ao instalar o software");

        //Console.WriteLine("\nChamado 3: Servidor caiu.");
        //suporteBasico.TratarChamado("Servidor fora do ar");

        ////Command ---------------------------------------------------------

        //// Criando os setores do restaurante
        //Cozinha cozinha = new Cozinha();
        //Bar bar = new Bar();

        //// Criando pedidos
        //IPedido pedido1 = new PedidoComida(cozinha, "Pizza");
        //IPedido pedido2 = new PedidoBebida(bar, "Caipirinha");

        //// Criando o garçom
        //Garcom garcom = new Garcom();

        //// Adicionando pedidos
        //garcom.AdicionarPedido(pedido1);
        //garcom.AdicionarPedido(pedido2);

        //// Processando os pedidos
        //garcom.ProcessarPedidos();

        //// Cancelando um pedido
        //Console.WriteLine("\nCancelando o último pedido...");
        //garcom.CancelarUltimoPedido();

        ////Mediator ---------------------------------------------------------

        //IMediadorChat chat = new MediadorChat();

        //var usuario1 = new UsuarioConcreto(chat, "Alice");
        //var usuario2 = new UsuarioConcreto(chat, "Bob");
        //var usuario3 = new UsuarioConcreto(chat, "Charlie");

        //// Registrando usuários no chat
        //chat.RegistrarUsuario(usuario1);
        //chat.RegistrarUsuario(usuario2);
        //chat.RegistrarUsuario(usuario3);

        //// Enviando mensagens
        //usuario1.EnviarMensagem("Olá, pessoal!");
        //usuario2.EnviarMensagem("Oi, Alice! Como vai?");
        //usuario3.EnviarMensagem("E aí, galera!");

        ////memento ---------------------------------------------------------
        //var blocoDeNotas = new BlocoDeNotas();
        //var historico = new Historico();

        //blocoDeNotas.Escrever("Primeiro texto.");
        //historico.SalvarEstado(blocoDeNotas.CriarMemento());

        //blocoDeNotas.Escrever("Segundo texto.");
        //historico.SalvarEstado(blocoDeNotas.CriarMemento());

        //blocoDeNotas.Escrever("Terceiro texto.");

        //// Desfazendo última alteração
        //var estadoAnterior = historico.Desfazer();
        //if (estadoAnterior != null)
        //{
        //    blocoDeNotas.RestaurarMemento(estadoAnterior);
        //}

        //// Desfazendo mais uma alteração
        //estadoAnterior = historico.Desfazer();
        //if (estadoAnterior != null)
        //{
        //    blocoDeNotas.RestaurarMemento(estadoAnterior);
        //}

        //observer ---------------------------------------------------------
        //var acao = new Acao("AAPL", 150.00);

        //var investidor1 = new Investidor("Alice");
        //var investidor2 = new Investidor("Bob");

        //acao.AdicionarInvestidor(investidor1);
        //acao.AdicionarInvestidor(investidor2);

        //// Atualizando preço da ação
        //acao.AtualizarPreco(155.50);
        //acao.AtualizarPreco(160.75);

        //// Removendo um investidor e atualizando novamente
        //acao.RemoverInvestidor(investidor1);
        //acao.AtualizarPreco(165.00);

        //Console.ReadKey();

        //state ---------------------------------------------------------

        //var maquina = new MaquinaCafe();

        //maquina.SelecionarCafe(); // Sem moeda
        //maquina.InserirMoeda();   // Inserindo moeda
        //maquina.InserirMoeda();   // Tentando inserir de novo
        //maquina.SelecionarCafe(); // Selecionando café
        //maquina.PrepararCafe();   // Café pronto
        //maquina.SelecionarCafe(); // Máquina voltou ao estado inicial

        //strategy ---------------------------------------------------------
        //var calculadora = new Calculadora();

        //// Definir a estratégia de soma
        //calculadora.DefinirOperacao(new Adicao());
        //Console.WriteLine($"Soma: {calculadora.ExecutarCalculo(5, 3)}");

        //// Definir a estratégia de subtração
        //calculadora.DefinirOperacao(new Subtracao());
        //Console.WriteLine($"Subtração: {calculadora.ExecutarCalculo(5, 3)}");

        //// Definir a estratégia de multiplicação
        //calculadora.DefinirOperacao(new Multiplicacao());
        //Console.WriteLine($"Multiplicação: {calculadora.ExecutarCalculo(5, 3)}");

        ////visitor ------------------------------------------------------------
        //List<Funcionario> funcionarios = new()
        //{
        //    new Desenvolvedor("Alex", 8000, "C#"),
        //    new Gerente("Jeniffer", 12000, 5)
        //};

        //var visitor = new RelatorioSalarioVisitor();

        //// Executando o visitor para cada funcionário
        //foreach (var funcionario in funcionarios)
        //{
        //    funcionario.Aceitar(visitor);
        //}

        //-----------WMS -------------------------------------------------------

        var uow = new UnitOfWork();
        var factory = new NotaFiscalFactory();

        // Configurar estratégia de endereçamento
        var estrategia = new EstrategiaEnderecamentoFIFO(uow.Enderecos);
        var enderecamento = new EnderecamentoService(estrategia);

        // Criar serviço com decorator
        IEstoqueService service = new EstoqueService(uow, factory, enderecamento);
        service = new ValidacaoDadosDecorator(service);

        // Registrar observadores
        var estoqueService = (EstoqueService)service;
        estoqueService.RegistrarObservador(new NotificadorEmail());
        estoqueService.RegistrarObservador(new NotificadorLog());

        // Popular dados iniciais
        PopularDadosTeste(uow);

        // Processar nota fiscal
        ProcessarNotaFiscal(service);

        Console.ReadKey();

    }


    static void PopularDadosTeste(IUnitOfWork uow)
    {
        uow.Enderecos.Adicionar(new Endereco(0, "Bloco A", "P1", "N1", false));
        uow.Enderecos.Adicionar(new Endereco(0, "Bloco B", "P2", "N2", false));

        var categoria = new Categoria { Id = 1, Descricao = "Matéria Prima" };
        uow.Produtos.Adicionar(new Produto
        {
            Id = 1,
            Descricao = "Parafuso Inox",
            Unidade = "UN",
            QuantidadeMinima = 100
        });
    }

    static void ProcessarNotaFiscal(IEstoqueService service)
    {
        try
        {
            var produto = service.ObterProduto(1) ?? throw new Exception("Produto não encontrado");

            service.ProcessarNotaCompleta("NF-2023-001", new List<(Produto, decimal, decimal)>
            {
                (produto, 0.75m, 500)
            });

            Console.WriteLine("Nota fiscal processada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

}

