<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientWebForm.aspx.cs" Inherits="SampleForHandsOnExp_WebApplication_WebServicesClient.ClientWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            First Number :
            <asp:TextBox ID="FirstNumber" runat="server"></asp:TextBox>
            <br />
            Second Number :
            <asp:TextBox ID="SecondNumber" runat="server"></asp:TextBox>
            <br />
            Result :
            <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>
            
            <br />
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
            
        </div>
    </form>
</body>
</html>
