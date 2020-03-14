using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.Entites
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string  Name { get; set; }
       
        public string UserName { get; set; }
        public string PassWord { set; get; }
        public string  SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

    }
}
