<%@ Page Title="" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WrapPanel2._default" %>
<%@ Register Src="~/ContentPanel.ascx" TagPrefix="uc" TagName="ContentPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script>

    </script>
    <style>

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <uc:ContentPanel runat="server" ID="ContentPanel" />
</asp:Content>
