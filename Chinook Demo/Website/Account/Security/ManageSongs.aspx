<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageSongs.aspx.cs" MasterPageFile="~/Site.master" Inherits="Account_Security_ManageSongs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Manager Song Database</h1>


    <div class="row">
        <div class="col-md-12">

        



            <asp:ListView ID="ListView1" runat="server" DataSourceID="SongsDataSource" InsertItemPosition="LastItem" DataKeyNames="TrackID" ItemType="Chinook.Framework.Entities.Track">
                <EditItemTemplate>
                    <span style="">TrackId:
                        <asp:TextBox Text='<%# Bind("TrackId") %>' runat="server" ID="TrackIdTextBox" /><br />
                        Name:
                        <asp:TextBox Text='<%# Bind("Name") %>' runat="server" ID="NameTextBox" /><br />
                        AlbumId:
                        <asp:TextBox Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdTextBox" /><br />
                        MediaTypeId:
                        <asp:TextBox Text='<%# Bind("MediaTypeId") %>' runat="server" ID="MediaTypeIdTextBox" /><br />
                        GenreId:
                        <asp:TextBox Text='<%# Bind("GenreId") %>' runat="server" ID="GenreIdTextBox" /><br />
                        Composer:
                        <asp:TextBox Text='<%# Bind("Composer") %>' runat="server" ID="ComposerTextBox" /><br />
                        Milliseconds:
                        <asp:TextBox Text='<%# Bind("Milliseconds") %>' runat="server" ID="MillisecondsTextBox" /><br />
                        Bytes:
                        <asp:TextBox Text='<%# Bind("Bytes") %>' runat="server" ID="BytesTextBox" /><br />
                        UnitPrice:
                        <asp:TextBox Text='<%# Bind("UnitPrice") %>' runat="server" ID="UnitPriceTextBox" /><br />
                        Album:
                        <asp:TextBox Text='<%# Bind("Album") %>' runat="server" ID="AlbumTextBox" /><br />
                        Genre:
                        <asp:TextBox Text='<%# Bind("Genre") %>' runat="server" ID="GenreTextBox" /><br />
                        InvoiceLines:
                        <asp:TextBox Text='<%# Bind("InvoiceLines") %>' runat="server" ID="InvoiceLinesTextBox" /><br />
                        MediaType:
                        <asp:TextBox Text='<%# Bind("MediaType") %>' runat="server" ID="MediaTypeTextBox" /><br />
                        Playlists:
                        <asp:TextBox Text='<%# Bind("Playlists") %>' runat="server" ID="PlaylistsTextBox" /><br />
                        <asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" /><asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" /><br />
                        <br />
                    </span>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <span>No data was returned.</span>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <span style="">TrackId:
                        <asp:TextBox Text='<%# Bind("TrackId") %>' runat="server" ID="TrackIdTextBox" /><br />
                        Name:
                        <asp:TextBox Text='<%# Bind("Name") %>' runat="server" ID="NameTextBox" /><br />
                        AlbumId:
                        <asp:TextBox Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdTextBox" /><br />
                        MediaTypeId:
                        <asp:TextBox Text='<%# Bind("MediaTypeId") %>' runat="server" ID="MediaTypeIdTextBox" /><br />
                        GenreId:
                        <asp:TextBox Text='<%# Bind("GenreId") %>' runat="server" ID="GenreIdTextBox" /><br />
                        Composer:
                        <asp:TextBox Text='<%# Bind("Composer") %>' runat="server" ID="ComposerTextBox" /><br />
                        Milliseconds:
                        <asp:TextBox Text='<%# Bind("Milliseconds") %>' runat="server" ID="MillisecondsTextBox" /><br />
                        Bytes:
                        <asp:TextBox Text='<%# Bind("Bytes") %>' runat="server" ID="BytesTextBox" /><br />
                        UnitPrice:
                        <asp:TextBox Text='<%# Bind("UnitPrice") %>' runat="server" ID="UnitPriceTextBox" /><br />
                        Album:
                        <asp:TextBox Text='<%# Bind("Album") %>' runat="server" ID="AlbumTextBox" /><br />
                        Genre:
                        <asp:TextBox Text='<%# Bind("Genre") %>' runat="server" ID="GenreTextBox" /><br />
                        InvoiceLines:
                        <asp:TextBox Text='<%# Bind("InvoiceLines") %>' runat="server" ID="InvoiceLinesTextBox" /><br />
                        MediaType:
                        <asp:TextBox Text='<%# Bind("MediaType") %>' runat="server" ID="MediaTypeTextBox" /><br />
                        Playlists:
                        <asp:TextBox Text='<%# Bind("Playlists") %>' runat="server" ID="PlaylistsTextBox" /><br />
                        <asp:Button runat="server" CommandName="Insert" Text="Insert" ID="InsertButton" /><asp:Button runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton" /><br />
                        <br />
                    </span>
                </InsertItemTemplate>
                <ItemTemplate>
                    <div style="">
                        Name:
                        <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" /><br />
                        AlbumId:
                        <asp:Label Text='<%# Eval("AlbumId") %>' runat="server" ID="AlbumIdLabel" /><br />
                        MediaTypeId:
                        <asp:Label Text='<%# Eval("MediaTypeId") %>' runat="server" ID="MediaTypeIdLabel" /><br />
                        GenreId:
                        <asp:Label Text='<%# Eval("GenreId") %>' runat="server" ID="GenreIdLabel" /><br />
                        Composer:
                        <asp:Label Text='<%# Eval("Composer") %>' runat="server" ID="ComposerLabel" /><br />
                        Milliseconds:
                        <asp:Label Text='<%# Eval("Milliseconds") %>' runat="server" ID="MillisecondsLabel" /><br />
                        Bytes:
                        <asp:Label Text='<%# Eval("Bytes") %>' runat="server" ID="BytesLabel" /><br />
                        UnitPrice:
                        <asp:Label Text='<%# Eval("UnitPrice") %>' runat="server" ID="UnitPriceLabel" /><br />
                        <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" />
                        <asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" />
                        <br />
                        <br />
                    </div>
                </ItemTemplate>
                <LayoutTemplate>
                    <div runat="server" id="itemPlaceholderContainer" style=""><span runat="server" id="itemPlaceholder" /></div>
                    <div style="">
                        <asp:DataPager runat="server" ID="DataPager1">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                                <asp:NumericPagerField></asp:NumericPagerField>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                            </Fields>
                        </asp:DataPager>

                    </div>
                </LayoutTemplate>
            </asp:ListView>





            <asp:ObjectDataSource runat="server" ID="SongsDataSource" DataObjectTypeName="Chinook.Framework.Entities.Track" DeleteMethod="DeleteTrack" InsertMethod="AddTrack" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllTracks" TypeName="Chinook.Framework.BLL.AdminCRUD" UpdateMethod="UpdateTrack"></asp:ObjectDataSource>
        </div>
    </div>


</asp:Content>