<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VKIDene.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <br />
    <b>Boyunuz:</b> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <b>&nbsp;&nbsp;(Örn. 1,72)&nbsp; Kilonuz:</b>  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(Örn. 70)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        Sonuç:</b>  
    <asp:TextBox ID="TextBox3" runat="server" Width="213px"></asp:TextBox>
    <b>İdeal Kilonuz: </b><asp:TextBox ID="TextBox4" runat="server" Width="213px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click" />
    </form>
</body>
</html>
