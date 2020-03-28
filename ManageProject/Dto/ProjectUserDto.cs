using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetWinForm.Entites;

namespace TimeSheetWinForm.ManageProject.Dto
{
    public class ProjectUserDto
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string  Type { get; set; }
        public long ProjectId { get; set; }
    }
}
