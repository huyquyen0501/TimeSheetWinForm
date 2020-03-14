using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.Entites
{
    public class Role
    {
        [Key]
        public long Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
