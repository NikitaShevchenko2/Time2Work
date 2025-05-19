using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IGenericService<T>
    {
        // interface containing CRUD for all services
        // generic, class gets added in implementation
        List<T> GetAll();
        T GetById(int id);
        void Update(T model);
        void Add(T model);
        void Delete(int id);
    }
}
