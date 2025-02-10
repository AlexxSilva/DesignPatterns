using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Facade
{
    public class Notificacao
    {
        public void EnviarEmail(string email)
        {
            Console.WriteLine($"Enviando email de confirmação para: {email}");
        }
    }
}
