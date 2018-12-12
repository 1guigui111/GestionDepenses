<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="lbl_username" Text="Nom d'utilisateur" />
            <asp:TextBox runat="server" ID="tbx_username" />
        </div>
        <div>
            <asp:Label runat="server" ID="lbl_password" Text="Mot de passe" />
            <asp:TextBox runat="server" ID="tbx_password" TextMode="Password" />
        </div>
        <div>
            <asp:Button runat="server" ID="btn_connexion" Text="Connexion" OnClick="btn_connexion_Click" />
        </div>
    </form>
</body>
</html>
