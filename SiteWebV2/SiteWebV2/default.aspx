<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Theme="Connexion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Connexion</title>
    <link rel="stylesheet" href="css/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container vertical-center">
            <asp:Table runat="server" CssClass="m-md-auto col-lg-6" ID="tab_Login">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        <i class="fas fa-gas-pump"></i>
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lbl_username" Text="Nom d'utilisateur" />
                        <asp:TextBox runat="server" ID="tbx_username" CssClass="form-control" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lbl_password" Text="Mot de passe" />
                        <asp:TextBox runat="server" ID="tbx_password" TextMode="Password" CssClass="form-control" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button runat="server" ID="btn_connexion" Text="Connexion" OnClick="btn_connexion_Click" CssClass="btn btn-success col-lg-12 " />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        
    </form>
</body>
</html>
