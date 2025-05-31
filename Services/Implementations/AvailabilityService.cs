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
    public class AvailabilityService : BaseService<Availability>, IGenericService<Availability>
    {
        // class containing all services for availability
        #region Constructor
        public AvailabilityService(IGenericRepo<Availability> repo) : base(repo)
        {
            
        }
        #endregion

        #region Methods
        public void Add(Availability model)
        {
            _repo.Add(model);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<Availability> GetAll()
        {
            return _repo.GetAll();
        }

        public Availability GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Update(Availability model)
        {
            _repo.Update(model);
        }
        #endregion
    }
}
