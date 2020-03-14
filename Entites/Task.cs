using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TimeSheetWinForm.Entites.StatusEnum;

namespace TimeSheetWinForm.Entites
{
    public class Task
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public TaskType Type { get; set; }

    }
}
