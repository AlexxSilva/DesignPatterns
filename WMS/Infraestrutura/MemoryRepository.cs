using DesignPatterns.WMS.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.WMS.Infraestrutura
{
    public class MemoryRepository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _entities = new();
        private int _nextId = 1;

        public void Adicionar(T entity)
        {
            var prop = entity.GetType().GetProperty("Id");
            prop?.SetValue(entity, _nextId++);
            _entities.Add(entity);
        }

        public T? ObterPorId(int id) =>
            _entities.FirstOrDefault(e => (int?)e.GetType().GetProperty("Id")?.GetValue(e) == id);

        public IEnumerable<T> ObterTodos() => _entities;
    }
}
