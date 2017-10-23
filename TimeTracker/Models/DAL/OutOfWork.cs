using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models.Enam;

namespace TimeTracker.Models.DAL
{
    public class OutOfWork
    {
        [Key]
        public int Id { get; set; }

        public int? ProjectId { get; set; }

        public Guid UserId { get; set; }

        public TypeVisible TypeVisible { get; set; }

        public int DaysOfIllness { get; set; }

        public int DaysOfVacation { get; set; }

        public int HoursPerDay { get; set; }

        public int HoursPerWeek { get; set; }
    }
}
