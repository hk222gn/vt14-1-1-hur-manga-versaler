<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="MainTextBox" runat="server"></asp:TextBox>

        <asp:Button ID="SubmitButton" runat="server" Text="Send" OnClick="SubmitButton_Click" />

        <asp:Label ID="CapitalLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
