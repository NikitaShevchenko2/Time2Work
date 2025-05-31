using DAL.Interfaces;
using Data.Models;
using Services.Abstractions;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class EmployeeService : BaseService<Employee>, IGenericService<Employee>
    {
        // class containing the services for the employee
        #region Constructor
        public EmployeeService(IGenericRepo<Employee> repo) : base(repo)
        {
            
        }
        #endregion

        #region Methods
        public void Add(Employee model)
        {
            _repo.Add(model);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<Employee> GetAll()
        {
            return _repo.GetAll();
        }

        public Employee GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Update(Employee model)
        {
            _repo.Update(model);
        }
        #endregion
    }
}
