using Chinook.Framework.DAL;
using Chinook.Framework.DAL.Security;
using Chinook.Framework.Entities.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chinook.Framework.BLL.Security
{
    [DataObject]
    public class UserManager : UserManager<ApplicationUser>
    {
        public UserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }

        #region Constants
        private const string STR_DEFAULT_PASSWORD = "Pa$$word1";
        /// <summary>Requires FirstName and Lastname</summary>
        private const string STR_USERNAME_FORMAT = "{0}.{1}";
        /// <summary>Requires UserName</summary>
        private const string STR_EMAIL_FORMAT = "{0}@ChinookLab.tba";
        private const string STR_WEBMASTER_USERNAME = "Webmaster";
        #endregion

        public void AddWebMaster()
        {
            if(!Users.Any(u=>u.UserName.Equals(STR_WEBMASTER_USERNAME)))
            {
                var webMasterAccount = new ApplicationUser()
                {
                    UserName = STR_WEBMASTER_USERNAME,
                    Email = string.Format(STR_EMAIL_FORMAT, STR_WEBMASTER_USERNAME)
                };
                this.Create(webMasterAccount, STR_DEFAULT_PASSWORD);
                this.AddToRole(webMasterAccount.Id, SecurityRoles.WebsiteAdmins);
            }
        } // end of AddWebMaster()



        #region CRUD Operations

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public List<UserProfile> ListAllUsers()
        {
            var rm = new RoleManager();
            var result = from person in Users.ToList() //.ToList() grabs data from the db first
                         select new UserProfile
                         {
                             UserId = person.Id,
                             UserName = person.UserName,
                             Email = person.Email,
                             EmailConfirmed = person.EmailConfirmed,
                             CustomerID = person.CustomerID,
                             EmployeeID = person.EmployeeID,
                             RoleMemberShips = person.Roles.Select(r => rm.FindById(r.RoleId).Name)

                         };

            using (var context = new ChinookContext())
            {
                foreach (var person in result)
                {
                    if(person.EmployeeID.HasValue)
                    {
                        var employee = context.Employees.Find(person.EmployeeID);
                        if (employee != null)
                        {
                            person.FirstName = employee.FirstName;
                            person.LastName = employee.LastName;
                        }
                    }
                    
                    else if(person.CustomerID.HasValue)
                    {
                        var customer = context.Customers.Find(person.CustomerID);
                        if (customer != null)
                        {
                            person.FirstName = customer.FirstName;
                            person.LastName = person.LastName;
                        }
                    }

                    
                }
               

            }

                return result.ToList();
        }//End of ListOfUsers


        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddUser(UserProfile userInfo)
        {
            //TODO:
        }






        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void RemoveUser(UserProfile userInfo)
        {
            //TODO:
        }

        #endregion
    }
}
