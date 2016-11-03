<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageSongs.aspx.cs" MasterPageFile="~/Site.master" Inherits="Account_Security_ManageSongs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Manager Song Database</h1>


    <div class="row">
        <div class="col-md-12">

        



            <asp:ListView ID="ListView1" runat="server" DataSourceID="SongsDataSource">
            </asp:ListView>





            <asp:ObjectDataSource runat="server" ID="SongsDataSource" DataObjectTypeName="Chinook.Framework.Entities.Track" DeleteMethod="DeleteTrack" InsertMethod="AddTrack" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllTracks" TypeName="Chinook.Framework.BLL.AdminCRUD" UpdateMethod="UpdateTrack"></asp:ObjectDataSource>
        </div>
    </div>


</asp:Content>