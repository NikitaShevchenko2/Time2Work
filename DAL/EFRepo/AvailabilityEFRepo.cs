using DAL.BaseRepo;
using DAL.Interfaces;
using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFRepo
{
    public class AvailabilityEFRepo: RepoBase, IGenericRepo<Availability>
    {
        #region Constructor
        public AvailabilityEFRepo(Context context) : base(context)
        {
        }
        #endregion

        #region Methods
        public List<Availability> GetAll()
        {
            return _context.Availabiliies.ToList();
        }

        public Availability GetById(int id)
        {
            return _context.Availabiliies.FirstOrDefault(e => e.Id == id);
        }

        // next method returns a boolean, to see if operation was succesfull
        public bool Update(Availability model)
        {
            Availability availabilityToUpdate = GetById(model.Id);
            bool success = true;

            if (availabilityToUpdate != null)
            {
                availabilityToUpdate.StartDate = model.StartDate;
                availabilityToUpdate.EndDate = model.EndDate;
            }
            else
            {
                throw new Exception("Bestelling niet geupdate.");
                success = false;
            }

            _context.SaveChanges();
            return success;
        }
        public void Add(Availability model)
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
