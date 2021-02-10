using Entities.Context;
using Entities.Core;
using Microsoft.EntityFrameworkCore;
using Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Base
{
    public class BaseService<T> : IService<T> where T : CoreEntity
    {
        private DbSet<T> _entities;
        private readonly ProjectContext _context;
        public BaseService(ProjectContext context)
        {
            this._context = context;
        }

        public bool Add(T item)
        {
            _context.Set<T>().Add(item);
            return true;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Remove(T item)
        {
            _context.Set<T>().Remove(item);
            return true;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
