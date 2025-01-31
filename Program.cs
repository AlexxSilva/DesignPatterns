// See https://aka.ms/new-console-template for more information
using DesignPatterns.Criacao.ConstrutorBuilder;
using DesignPatterns.Criacao.Metodofabrica;
using DesignPatterns.Criacao.Singleton;


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