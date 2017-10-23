<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Button runat="server" ID="btnShowMessage" Text="Get Message" OnClick="btnShowMessage_Click" /><br />
       WCF Message: <asp:Label runat="server" ID="msg"></asp:Label>
    </div>
    </form>
</body>
</html>
