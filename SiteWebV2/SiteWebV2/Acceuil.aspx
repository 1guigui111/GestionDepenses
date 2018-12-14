<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaitre.master" AutoEventWireup="true" CodeFile="Acceuil.aspx.cs" Inherits="Acceuil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_title" Runat="Server">
    Acceuil
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:Repeater runat="server" ID="rep_data">
        <ItemTemplate>
            <p><%# Eval("ddate")%> |</p>
            <%--<%# Eval("") %>--%>
            <hr />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

