﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamental.Iterator
{
    public interface IColecaoPedidos
    {
        IIteradorPedidos CriarIterador();
    }
}
