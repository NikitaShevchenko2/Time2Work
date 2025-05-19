using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public abstract class BaseService<T>
    {
        // shortcut for instatiating the repo, gets added in program.cs in MVC
        protected IGenericRepo<T> _repo;

        protected BaseService(IGenericRepo<T> repo)
        {
            _repo = repo;
        }
    }
}
