using System;
using System.Collections.Generic;

namespace NetCoreConsoleApp
{
    public class Account
    {
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
    }
}