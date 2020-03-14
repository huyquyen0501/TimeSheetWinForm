using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.Entites
{
    public class UserRole
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey(nameof(UserId))]
        public User Users { get; set; }
        public long UserId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public Role Roles { get; set; }
        public long RoleId { get; set; }
    }
}
