using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_4
{
   public class Account
    {
        private string EmpID;
        private string EmpPassword;
        private Boolean EmpRole;

        public Account()
        {
        }

        public Account(string empID, string empPassword, bool empRole)
        {
            EmpID1 = empID;
            EmpPassword1 = empPassword;
            EmpRole1 = empRole;
        }

        public string EmpID1 { get => EmpID; set => EmpID = value; }
        public string EmpPassword1 { get => EmpPassword; set => EmpPassword = value; }
        public bool EmpRole1 { get => EmpRole; set => EmpRole = value; }
    }
}
