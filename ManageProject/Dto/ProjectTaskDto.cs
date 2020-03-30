using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.ManageProject.Dto
{   
    public class ProjectTaskDto
    {
        public long ProjectId { get; set; }
        public long TaskId { get; set; }
        public string TaskName { get; set; }
        public string Billable { get; set; }
    }
}
