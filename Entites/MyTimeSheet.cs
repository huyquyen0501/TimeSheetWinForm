using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TimeSheetWinForm.Entites.StatusEnum;

namespace TimeSheetWinForm.Entites
{
    public class MyTimesheet 
    {
        [Key]
        public long Id { get; set; }
        public long ProjectTaskId { get; set; }

        [ForeignKey(nameof(ProjectTaskId))]
        public ProjectTask ProjectTask { get; set; }

        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public TypeOfWork TypeOfWork { get; set; }
        public bool IsCharged { get; set; }
        public string Note { get; set; }

        public TimesheetStatus Status { get; set; }

        public DateTime DateAt { get; set; }
        public int WorkingTime { get; set; }//min     
    }
}
