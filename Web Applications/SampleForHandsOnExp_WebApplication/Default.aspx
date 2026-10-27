<%@ Page Title="Home Page" Language="C#"  CodeBehind="Default.aspx.cs" Inherits="SampleForHandsOnExp_WebApplication._Default" %>


<form id="form1" runat="server">
    <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
    <asp:GridView ID="ResultGridView" runat="server">
    </asp:GridView>
</form>



