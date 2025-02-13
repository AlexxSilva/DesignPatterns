using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Dominio.Interfaces
{
    public interface IRepository<T>
    {
        void Adicionar(T entity);
        T? ObterPorId(int id);
        IEnumerable<T> ObterTodos();
    }
}
