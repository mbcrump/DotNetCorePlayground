using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetCoreConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account
            {
                Email = "michael@blah.com",
                Active = true,
                CreatedDate = new DateTime(2017, 2, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                     "User",
                     "Admin"
                }
            };

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            // {
            //   "Email": "james@example.com",
            //   "Active": true,
            //   "CreatedDate": "2013-01-20T00:00:00Z",
            //   "Roles": [
            //     "User",
            //     "Admin"
            //   ]
            // }

            Console.WriteLine(json);

        }
    }
}
