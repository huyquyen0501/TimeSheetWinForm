using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetWinForm.Utils
{
  public static  class Session
    {
        public static long UserSessionId { set; get; }
        public static List<string> RoleNameOfUser { set; get; }
        public static string Name { set; get; }
        
    }
}
