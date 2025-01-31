using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Criacao.Singleton
{
    public class Logger
    {
        // Instância única do Logger
        private static Logger _instancia;

        // Caminho do arquivo de log
        private string _caminhoArquivoLog;

        // Construtor privado para evitar a criação de instâncias fora da classe
        private Logger()
        {
            // Define o caminho do arquivo de log
            _caminhoArquivoLog = "log.txt";
            Console.WriteLine("Logger inicializado. Arquivo de log: " + _caminhoArquivoLog);
        }

        // Propriedade para acessar a instância única
        public static Logger Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Logger();
                }
                return _instancia;
            }
        }

        // Método para registrar uma mensagem no log
        public void Registrar(string mensagem)
        {
            string logEntry = $"{DateTime.Now}: {mensagem}";
            File.AppendAllText(_caminhoArquivoLog, logEntry + Environment.NewLine);
            Console.WriteLine(logEntry); // Exibe no console também
        }
    }
}
