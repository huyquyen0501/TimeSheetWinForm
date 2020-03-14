using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.Entites
{
    public class StatusEnum
    {
        public enum ProjectStatus
        {
            Active = 0,
            Deactive = 1,
        }
        public enum ProjectType
        {
            TimeAndMaterials = 0,
            FixedFee = 1,
            NoneBillable = 2
        }
        public enum TaskType
        {
            CommonTask = 0,
            OrtherTask = 1
        }
        public enum TypeOfWork
        {
            NormalWorkingHours = 0,
            OverTime = 1
        }
        public enum TimesheetStatus
        {
            All = -1,
            None = 0,
            Pending = 1,
            Approve = 2,
            Reject = 3
        }
        public enum TimesheetSort
        {
            Project = 0,
            People = 1,
            Week = 2
        }
    }
}
