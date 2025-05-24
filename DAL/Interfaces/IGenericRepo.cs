using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepo<T>
    {
        // interface containing CRUD for all DAL-repo's
        // generic, class gets added in implementation
        List<T> GetAll();
        T GetById(int id);
        bool Update(T model);
        void Add(T model);
        void Delete(int id);
    }
}
