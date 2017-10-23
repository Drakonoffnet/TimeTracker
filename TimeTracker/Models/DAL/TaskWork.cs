using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.DAL
{
    public class TaskWork
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
 
        public Guid OwnerId { get; set; }

        [Required]
        public Guid AppointedToId { get; set; }

        [Required]
        public DateTime PostDate { get; set; }
        [Required]
        public DateTime ExpectStartTask { get; set; }
        [Required]
        public DateTime ExpectEndTask { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Discription { get; set; }

        public int TaskTypeId { get; set; }

        [ForeignKey("TaskTypeId")]
        public virtual TaskType TaskType { get; set; }

        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public virtual StatusTask StatusTask { get; set; }
    }
}
