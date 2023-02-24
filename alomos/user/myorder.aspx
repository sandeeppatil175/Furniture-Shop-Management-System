<%@ Page Language="C#" MasterPageFile="~/user/Masteruser.master" AutoEventWireup="true" CodeFile="myorder.aspx.cs" Inherits="user_myorder" Title="myorder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center style="background-color: #CCFF99">

     <asp:TextBox ID="SearchByTagTB" runat="server" Font-Bold="True" Width="338px" 
         BorderColor="#990000" Font-Size="Large"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="SearchByTagButton" runat="server" Text="SEARCH"
            onclick="SearchByTagButton_Click" BackColor="#6699FF" 
         BorderColor="#990000" Font-Bold="True" ForeColor="Black" /><br />
        <asp:GridView ID="gvPatients" runat="server"></asp:GridView>

</center>





</asp:Content>

