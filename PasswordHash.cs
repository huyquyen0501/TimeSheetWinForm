

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace TimeSheetWinForm
{
    public class PasswordHash
    {
        public bool CheckPassWord(string PassWordUnHash, string Hashed)
        {
            return BCrypt.Net.BCrypt.Verify(PassWordUnHash, Hashed);
        }
        
    }
   
}
