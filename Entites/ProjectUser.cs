using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.Entites
{
    public class ProjectUser 
    {
        public long Id { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public long UserId { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }
        public long ProjectId { get; set; }

        public ProjectUserType Type { get; set; }

    }

    public enum ProjectUserType
    {
        Billable = 0,
        PM = 1,
    }
}
