using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Availability
    {
        // class containing properties for availability
        #region Properties
        [Key]
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        // date of availability
        public DateTime Date {  get; set; }
        // starting time of availability
        public TimeSpan? StartTime { get; set; }
        // end time of availability
        public TimeSpan? EndTime { get; set; }
        // availability can be easily changed without deleting 
        public bool IsAvailable { get; set; }
        #endregion
    }
}
