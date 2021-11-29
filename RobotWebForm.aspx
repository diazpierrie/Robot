<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CintaTrans.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        #form1 {
            width: 543px;
            height: 300px;
            margin-right: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 631px">
            --------------------------------------------------------------------------------------------------------
        </div>
        <p style="width: 483px; margin-left: 40px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PANEL VIEW ROBOT</p>

        <p style="width: 483px; margin-left: 40px;">
            <asp:Button ID="btnOn" runat="server" Text="ON" BackColor="Lime" OnClick="OnBtnOnClick" Width="41px" Style="height: 26px" />
        </p>

        <p style="width: 483px; margin-left: 40px; margin-top: 1px">

            <asp:Button ID="btnOff" runat="server" Text="OFF" BackColor="Red" OnClick="OnBtnOffClick" />
        </p>
        <p style="width: 420px">
            PRODUCTOS APILADOS POR ROBOT-----><asp:Label ID="LabelTotalPila" runat="server" Text="0"></asp:Label>
        </p>

        <p style="width: 635px; margin-top: 70px">
            <asp:Button ID="btnCintaOff" runat="server" BackColor="Red" Text="Off" OnClick="OnBtnCintaOffClick" />
            <asp:Button ID="btnCintaOn" runat="server" BackColor="Lime" Text="CINTA" Width="94px" OnClick="OnBtnCintaOnClick" />
            <asp:Image ID="Image1" runat="server" BorderColor="Black" Height="297px" ImageUrl="~/Resource/brazo-sin-bulto.png" Style="margin-left: 0px" Width="241px" />
            <asp:Button ID="btnPrensaOn" runat="server" BackColor="Lime" OnClick="OnBtnPrensaOnClick" Text="PRENSA" Width="96px" />
            <asp:Button ID="btnPrensaOff" runat="server" BackColor="Red" Text="Off" OnClick="OnBtnPrensaOffClick" />
            <asp:Button ID="btnPilaOff" runat="server" BackColor="Red" Height="34px" OnClick="OnBtnPilaOffClick" Style="margin-left: 127px; margin-top: 11px" Text="Off" Width="38px" />
            <asp:Button ID="btnPilaOn" runat="server" BackColor="Lime" Height="32px" OnClick="OnBtnPilaOnClick" Text="PILA" Width="87px" />
        </p>
        <p style="width: 200px; height: 22px; margin-top: 10px">
            <asp:RadioButton ID="rbEncendido" runat="server" Text="Encendido" />
        </p>
        <p style="width: 200px; height: 22px; margin-top: 10px">
            <asp:RadioButton ID="rbPrensa" runat="server" Text="Prensa" />
        </p>
        <p style="width: 200px; height: 22px; margin-top: 10px">
            <asp:RadioButton ID="rbCinta" runat="server" Text="Cinta" />
        </p>
        <p style="width: 200px; height: 25px; margin-top: 10px">
            <asp:RadioButton ID="rbPila" runat="server" Text="Apilados" />
        </p>
    </form>
</body>
</html>