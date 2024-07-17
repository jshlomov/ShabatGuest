using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.DAL.Rpository
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public int Insert(T entity);
    }
}
