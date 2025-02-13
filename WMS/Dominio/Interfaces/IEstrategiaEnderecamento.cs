﻿using DesignPatterns.WMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Interfaces
{
    public interface IEstrategiaEnderecamento
    {
        Endereco? EncontrarEnderecoDisponivel(Produto produto);
    }
}
