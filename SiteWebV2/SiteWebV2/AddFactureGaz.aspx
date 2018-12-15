<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaitre.master" AutoEventWireup="true" CodeFile="AddFactureGaz.aspx.cs" Inherits="AddFactureGaz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_title" Runat="Server">
    Ajouter Gaz
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <div>
        <asp:Label runat="server" ID="lbl_nbKilo" Text="Nombre kilo" />
        <asp:TextBox runat="server" ID="tbx_nbKilo" />
    </div>
    <div>
        <asp:Label runat="server" ID="lbl_litre" Text="Litre consommé" />
        <asp:TextBox runat="server" ID="tbx_litre" />
    </div>
    <div>
        <asp:Label runat="server" ID="lbl_cout" Text="Coût" />
        <asp:TextBox runat="server" ID="tbx_cout" />
    </div>
    <div>
        <asp:TextBox TextMode="Date" ID="tbx_calender" runat="server" />
    </div>
    <div>
        <asp:Button runat="server" ID="btn_appliquer" OnClick="btn_appliquer_Click" Text="Ajouter" />
    </div>
</asp:Content>

