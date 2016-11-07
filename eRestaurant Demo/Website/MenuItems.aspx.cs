using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRestaurant.BLL; // use the MenuController

public partial class MenuItems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            MenuController controller = new MenuController();
            var stuff = controller.GetRestaurantMenu();
            MenuGridview.DataSource = stuff;
            MenuGridview.DataBind();

            MenuRepeater.DataSource = stuff;
            MenuRepeater.DataBind();
        }
    }


    protected void ShowWaiter_Click(object sender, EventArgs e)
    {
        if (WaitersDropDown.SelectedIndex == 0)
            MessageUserControl.ShowInfo("Please select a waiter before clicking Show Waiter.");
        else
            MessageUserControl.TryRun((ProcessRequest)GetWaiterInfo);
    }
    public void GetWaiterInfo()
    {
        RestaurantAdminController controller = new RestaurantAdminController();
        var waiter = controller.GetWaiter(int.Parse(WaitersDropDown.SelectedValue));
        WaiterID.Text = waiter.WaiterID.ToString();
        FirstName.Text = waiter.FirstName;
        LastName.Text = waiter.LastName;
        Phone.Text = waiter.Phone;
        Address.Text = waiter.Address;
        HireDate.Text = waiter.HireDate.ToShortDateString();
        if (waiter.ReleaseDate.HasValue)
            ReleaseDate.Text = waiter.ReleaseDate.Value.ToShortDateString();
    }
}