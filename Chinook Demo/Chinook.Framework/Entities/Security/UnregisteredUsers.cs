using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Framework.Entities.Security
{
    public enum UnregisteredUserType {Undefined, Customer, Employee }
    public class UnregisteredUsers
    {
        public int ID { get; set; }
        public UnregisteredUserType UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssignedUserName { get; set; }
        public string AssignedEmail { get; set; }
    }
}
