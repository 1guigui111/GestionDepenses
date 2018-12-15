<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaitre.master" AutoEventWireup="true" CodeFile="Acceuil.aspx.cs" Inherits="Acceuil" Theme="Acceuil" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_title" Runat="Server">
    Acceuil
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <asp:Table runat="server" ID="tab_data" CssClass="table" />
    <asp:chart
</asp:Content>

