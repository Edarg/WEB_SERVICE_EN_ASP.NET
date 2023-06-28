<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consumocrud.aspx.cs" Inherits="CONSUMOWEB.consumocrud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtId" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 59px" Width="173px"></asp:TextBox>
        </p>
        <p>
            Nombre<asp:TextBox ID="txtNombre" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 59px" Width="173px"></asp:TextBox>
        </p>
        <p>
            Lanzamiento<asp:TextBox ID="txtLanzamiento" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 59px" Width="173px"></asp:TextBox>
        </p>
        <p>
            Desarrollador<asp:TextBox ID="txtDesarrollador" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 59px" Width="173px"></asp:TextBox>
        </p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="191px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="259px">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" Width="121px" />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Width="121px" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Width="121px" />
        </p>
    </form>
</body>
</html>
