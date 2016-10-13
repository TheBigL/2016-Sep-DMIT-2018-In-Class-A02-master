<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Security_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row jumbotron">
        <h1>Site Administration</h1>
    </div>
    <div class="row">
        <div class="col-md-12">
            <!-- Nav tabs -->
            <ul class="nav nav-tabs">
                <li class="active"><a href="#users" data-toggle="tab">Users</a></li>
                <li><a href="#roles" data-toggle="tab">Security Roles</a></li>
                <li><a href="#unregistered" data-toggle="tab">Unregistered Users</a></li>
            </ul>
            <div class="tab-content">
                <div class="tab-pane fade in active" id="users">
                    <asp:ListView ID="UserListView" runat="server"
                         DataSourceID="UserProfileDataSource"
                         ItemType="Northwind.Application.Security.UserProfile"
                         DataKeyNames="UserId" InsertItemPosition="LastItem"
                         OnItemInserting="UserListView_ItemInserting">
                        <LayoutTemplate>
                            <div class="row bg-info">
                                <div class="col-sm-2 h4">Action</div>
                                <div class="col-sm-2 h4">User Name</div>
                                <div class="col-sm-5 h4">Profile</div>
                                <div class="col-sm-3 h4">Roles</div>
                            </div>
                            <div runat="server" id="itemPlaceholder"></div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-sm-2"><asp:LinkButton runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" /></div>
                                <div class="col-sm-2"><%# Item.UserName %></div>
                                <div class="col-sm-5">
                                    <%# Item.Email %>
                                    <%# Item.FirstName + " " + Item.LastName %>
                                </div>
                                <div class="col-sm-3">
                                    <asp:Repeater ID="RoleUserRepeater" runat="server"
                                            DataSource="<%# Item.RoleMemberships %>" ItemType="System.String">
                                        <ItemTemplate><%# Item %></ItemTemplate>
                                        <SeparatorTemplate>, </SeparatorTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </ItemTemplate>
                        <InsertItemTemplate>
                            <hr />
                            <div class="row">
                                <div class="col-sm-2">
                                    <asp:LinkButton runat="server" CommandName="Insert" Text="Insert" ID="InsertButton" />
                                    <asp:LinkButton runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton" />
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox Text='<%# BindItem.UserName %>' runat="server" ID="UserNameTextBox" placeholder="User Name" />
                                </div>
                                <div class="col-sm-5">
                                    <asp:TextBox Text='<%# BindItem.Email %>' runat="server" ID="EmailTextBox" placeholder="Email" TextMode="Email" />
                                </div>
                                <div class="col-sm-3">
                                    <asp:CheckBoxList ID="RoleMemberships" runat="server" DataSource="<%# GetRoleNames() %>"></asp:CheckBoxList>
                                </div>
                            </div>
                        </InsertItemTemplate>
                    </asp:ListView>
                    <asp:ObjectDataSource ID="UserProfileDataSource" runat="server" DataObjectTypeName="Northwind.Application.Security.UserProfile" DeleteMethod="RemoveUser" InsertMethod="AddUser" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllUsers" TypeName="Northwind.Application.Security.UserManager"></asp:ObjectDataSource>
                </div>
                <div class="tab-pane fade" id="roles">
                    <asp:ListView ID="RoleListView" runat="server" DataSourceID="RoleDataSource" 
                         InsertItemPosition="LastItem" DataKeyNames="RoleId" 
                         ItemType="Northwind.Application.Security.RoleProfile">
                        <EmptyDataTemplate>
                            <span>No security roles have been set up.</span>
                        </EmptyDataTemplate>
                        <LayoutTemplate>
                            <div class="row bg-info">
                                <div class="col-sm-3 h4">Action</div>
                                <div class="col-sm-3 h4">Role</div>
                                <div class="col-sm-6 h4">Members</div>
                            </div>
                            <div runat="server" id="itemPlaceholder"></div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-sm-3"><asp:LinkButton runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" /></div>
                                <div class="col-sm-3">
                                    <%# Item.RoleName %>
                                </div>
                                <div class="col-sm-6">
                                    <asp:Repeater ID="RoleUserRepeater" runat="server"
                                            DataSource="<%# Item.UserNames %>" ItemType="System.String">
                                        <ItemTemplate><%# Item %></ItemTemplate>
                                        <SeparatorTemplate>, </SeparatorTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </ItemTemplate>
                        <InsertItemTemplate>
                            <hr />
                            <div class="row">
                                <div class="col-sm-3">
                                    <asp:LinkButton runat="server" CommandName="Insert" Text="Insert" ID="InsertButton" />
                                    <asp:LinkButton runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton" />
                                </div>
                                <div class="col-sm-3">
                                    <asp:TextBox Text='<%# BindItem.RoleName %>' runat="server" ID="RoleNameTextBox" placeholder="Role Name" />
                                </div>
                            </div>
                        </InsertItemTemplate>
                    </asp:ListView>
                    <asp:ObjectDataSource runat="server" ID="RoleDataSource" DataObjectTypeName="Northwind.Application.Security.RoleProfile" DeleteMethod="RemoveRole" InsertMethod="AddRole" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllRoles" TypeName="Northwind.Application.Security.RoleManager"></asp:ObjectDataSource>
                </div>
                <div class="tab-pane fade" id="unregistered">
                    TBA: Show unregistered Customers and Employees
                </div>
            </div>
        </div>
    </div>
</asp:Content>

