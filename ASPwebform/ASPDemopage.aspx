<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPDemopage.aspx.cs" Inherits="ASPwebform.ASPDemopage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <div>
        </div>
    </form>
    
</body>
</html>
