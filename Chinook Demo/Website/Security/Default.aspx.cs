using Chinook.Framework.BLL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Security_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Force all non WebsiteAdmins to go back the home page.
        if (!User.IsInRole("WebsiteAdmins"))
            Response.Redirect("~/Default.aspx", true);
    }
        protected List<string> GetRoleNames()
    {
        var mgr = new RoleManager(); // don't forget the Using statement at the top
        List<string> data = mgr.Roles.Select(r => r.Name).ToList();
        return data;
    }


    protected void UserListView_ItemInserting(object sender, ListViewInsertEventArgs e)
    {
        var addToRoles = new List<string>();
        var rolesCheckBoxList = e.Item.FindControl("RoleMemberships") as CheckBoxList;
        //                                         \ control on form/ \ "safe" casting/
        if(rolesCheckBoxList != null)
        {
            foreach (ListItem item in rolesCheckBoxList.Items)
                if (item.Selected)
                    addToRoles.Add(item.Value);
        }
        e.Values["RoleMemberships"] = addToRoles;
        //       \ Property name /
        //        \ of the      /
        //         \UserProfile/
        //          \ class   /
    }

}