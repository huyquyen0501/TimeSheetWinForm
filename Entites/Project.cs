using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TimeSheetWinForm.Entites.StatusEnum;

namespace TimeSheetWinForm.Entites
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public ProjectStatus Status { get; set; }
        public string Code { get; set; }
        public ProjectType ProjectType { get; set; }
        public string Note { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }
        public long CustomerId { get; set; }
    }
}
