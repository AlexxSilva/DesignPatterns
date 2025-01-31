﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.estrutural.Bridge
{
    public class Navio : ITransportadora
    {
        public void Entregar(string pacote)
        {
            Console.WriteLine($"Entregando {pacote} via Navio.");
        }
    }
}
