using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models.Enam;

namespace TimeTracker.Models.DAL
{
    public class TaskDefaultValue
    {
        [Key]
        public int Id { get; set; }

        public int? ProjectId { get; set; }

        public TypeVisible TypeVisible { get; set; }

        public string Subject { get; set; }

        public string Discription { get; set; }

        [ForeignKey("TaskTypeId")]
        public virtual TaskType TaskType { get; set; }

        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public virtual StatusTask StatusTask { get; set; }
    }
}
