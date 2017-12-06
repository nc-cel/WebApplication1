<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="CategoryMenu" style="text-align: center">       
        <asp:ListView ID="destinationList"  
                      ItemType="WebApplication1.Account.Models.Destination" 
                      runat="server"
                      SelectMethod="GetDestination" >
            <ItemTemplate>
                <b style="font-size: large; font-style: normal">
                    <a href="/ProductList.aspx?id=<%#: Item.DestinationID %>">
                        <%#: Item.DestinationName %>
                    </a>
                </b>
            </ItemTemplate>
            <ItemSeparatorTemplate>  |  </ItemSeparatorTemplate>
        </asp:ListView>
    </div>

</asp:Content>
