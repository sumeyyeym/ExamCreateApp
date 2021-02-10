using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Core
{
    public interface IService<T> where T : CoreEntity
    {
        public bool Add(T item);
        public bool Remove(T item);
        public T GetById(Guid id);
        public List<T> GetAll();
        public int Save();

    }
}
