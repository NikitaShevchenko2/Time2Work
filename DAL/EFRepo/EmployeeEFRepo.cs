using DAL.Interfaces;
using Data.Models;
using DAL.BaseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;

namespace DAL.EFRepo
{
    public class EmployeeEFRepo : RepoBase, IGenericRepo<Employee>
    {
        // class contating CRUD-operations for the Employee EF repo
        #region Constructor
        public EmployeeEFRepo(Context context): base(context)
        { 
        }
        #endregion

        #region Methods
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        // next method returns a boolean, to see if operation was succesfull
        public bool Update(Employee model)
        {
            Employee employeeToUpdate = GetById(model.Id);
            bool success = true;

            if (employeeToUpdate != null) 
            {
                employeeToUpdate.FirstName = model.FirstName;
                employeeToUpdate.LastName = model.LastName;
                employeeToUpdate.Email = model.Email;
                employeeToUpdate.Phone = model.Phone;
            }
            else
            {
                throw new Exception("Bestelling niet geupdate.");
                success = false;
            }
            
            _context.SaveChanges();
            return success;
        }
        public void Add(Employee model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(GetById(id));
            _context.SaveChanges();
        }
        #endregion
    }
}
