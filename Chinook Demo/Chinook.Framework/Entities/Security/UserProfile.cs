using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Framework.Entities.Security
{
    /// <summary>
    /// UserProfile is a Data Transfer Object summarizing information
    /// about a single user on the website.
    /// </summary>
    public class UserProfile
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string MyProperty { get; set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<string> RoleMemberShips { get; set; } 
    }
}
