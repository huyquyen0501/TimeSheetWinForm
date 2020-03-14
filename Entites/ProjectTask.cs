using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.Entites
{
   public class ProjectTask
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey(nameof(TaskId))]
        public Task Task { get; set; }
        public long TaskId { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }
        public long ProjectId { get; set; }

        public bool Billable { get; set; }
    }
}
