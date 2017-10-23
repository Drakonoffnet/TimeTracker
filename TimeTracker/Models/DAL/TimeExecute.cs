using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.DAL
{
    public class TimeExecute
    {
        [Key]
        public int Id { get; set; }

        public int TaskId { get; set; }

        [ForeignKey("TaskId")]
        public Task Task { get; set; }

        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

        public virtual TimeSpan SpentTime() => Stop - Start;

        public  bool IsOpen { get; set; }      

    }
}
