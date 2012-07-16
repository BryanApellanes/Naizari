using System;
using System.Collections.Generic;
using System.Text;

namespace Naizari.Ldap.ActiveDirectory
{
    public class PasswordChangeResult
    {
        public PasswordChangeResultStatus Status
        {
            get;
            set;
        }

        public string StackTrace{ get; set; }
        public string UserName { get; set; }
        public string Domain { get; set; }
        public string ErrorMessage { get; set; }
    }
}
