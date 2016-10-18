<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Security_Default" MasterPageFile="~/Site.master"  %>

<asp:content id="Content1" contentplaceholderid="MainContent" runat="server">
    <div class="row jumbotron">
        <h1>Site AdminStration</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <ul class="nav nav-tabs">
                <li class="active"><a href="#users" data-toggle="tab">Security Roles</a></li>
                 <li><a href="#roles" data-toggle="tab">Security Roles</a></li>
                <li><a href="#unregistered" data-toggle="tab">Unregistered Users</a></li>
            </ul>

            <div class="tab-content">
                <div class="tab-pane fade in active" id="users">TBA: Show website user details
                
                <asp:ListView ID="ListView1" runat="server"
                          DataSourceID="UserProfileDataSource">
 
                     </asp:ListView>
                     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>

                    <asp:ObjectDataSource ID="UserProfileDataSource" runat="server" SelectMethod="ListAllUsers" TypeName="Chinook.Framework.BLL.Security.UserManager" OldValuesParameterFormatString="original_{0}" DataObjectTypeName="Chinook.Framework.Entities.Security.UserProfile" DeleteMethod="RemoveUser" InsertMethod="AddUser"></asp:ObjectDataSource>
                    <asp:ListView ID="UserListview" runat="server" DataSourceID="UserProfileDataSource" ItemType="Chinook.Framework.Entities.Security.UserProfile">

                       
                    </asp:ListView>
                </div>

                <asp:ListView ID="RoleListView" runat="server" DataSourceID="RoleDataSource" DataKeyNames="RoleID" ItemType="Chinook.Framework.Entities.Security.RoleProfile">
                    <LayoutTemplate>
                        
                        <div class="row bg-info">
                            <div class="col-md-3 h4">Action</div>
                            <div class="col-md-3 h4">Action</div>
                            <div class="col-md-3 h4">Action</div>
                        </div>
                        <div runat="server" id="itemPlaceHolder">


                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="row">
                            <div class="col-md-3"></div>
                            <div class="col-md-3">
                                <asp:LinkButton runat="server" ID="DeleteButton" CommandName="Delete" Text="Delete"/>

                            </div>
                            <div class="col-md-6">
                                <asp:Repeater ID="RoleUserRepeater" runat="server" ItemType="System.String" DataSource="<%# Item.UserNames %>">
                                    <ItemTemplate>
                                        <%#Item %>
                                    </ItemTemplate>
                                    <SeparatorTemplate>, </SeparatorTemplate>

                                </asp:Repeater>
                                    
                            </div>
                        </div>
                    </ItemTemplate>
                    <InsertItemTemplate>

                        <br />
                        <div class="row">
                            <div class="col-md-3">
                                <asp:LinkButton runat="server" ID="InsertButton" CssClass="btn btn-default" CommandName="Insert" Text="Add Role"/>
                                <asp:LinkButton runat="server" ID="RemoveButton" CssClass="btn btn-default" CommandName="Delete" Text="Remove Role"/>

                            </div>


                        </div>

                    </InsertItemTemplate>

                </asp:ListView>

                <div class="tab-pane fade" id="roles">TBA: Show website user details
                    <asp:ObjectDataSource ID="RoleDataSource" runat="server" DataObjectTypeName="Chinook.Framework.Entities.Security.RoleProfile" 
                    DeleteMethod="RemoveRole" InsertMethod="AddRole" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllRoles" 
                    TypeName="Chinook.Framework.BLL.Security.RoleManager"></asp:ObjectDataSource>
                    </div>
                <div class="tab-pane fade" id="unregistered">TBA: Show Unregistered Customers & Employees</div>
            </div>
        </div>
    </div>
</asp:content>
