<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Obra.aspx.cs" Inherits="Constructora.Obra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <div>
            <ul class="navbar-nav">
                <li class="nav-item"><a class="nav-link" href="Index.aspx">Inicio</a> </li>
                <li class="nav-item"><a class="nav-link" href="Materiales.aspx">Materiales</a> </li>
                <li class="nav-item"><a class="nav-link" href="ProveedorMaterial.aspx">Proveedora materiales</a> </li>
            </ul>
        </div>
    <form id="form1" runat="server">
        <center>
             <p>
            <asp:Label ID="Label1" runat="server" Text="Obra"></asp:Label>
        </p>
             <p>
                 <asp:Label ID="Label2" runat="server" Text="Nombre de la obra:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="TextBox1" runat="server" Width="156px"></asp:TextBox>
        </p>
             <p>
                 <asp:Label ID="Label3" runat="server" Text="Direccion: "></asp:Label>
&nbsp;&nbsp;
                 <asp:TextBox ID="TextBox2" runat="server" Width="225px"></asp:TextBox>
        </p>
             <p>
                 <asp:Label ID="Label4" runat="server" Text="Fecha de inicio:"></asp:Label>
&nbsp;
                 <asp:TextBox ID="TextBox3" runat="server" Width="191px"></asp:TextBox>
        </p>
             <p>
                 <asp:Label ID="Label6" runat="server" Text="Fecha de termino:"></asp:Label>
                 <asp:TextBox ID="TextBox6" runat="server" Width="191px"></asp:TextBox>
        </p>
             <p>
                 <asp:Label ID="Label5" runat="server" Text="Selecciona el dueño de la obra:"></asp:Label>
        </p>
             <p>
                 <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                     </Columns>
                     <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                     <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                     <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                     <RowStyle BackColor="White" ForeColor="#003399" />
                     <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                     <SortedAscendingCellStyle BackColor="#EDF6F6" />
                     <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                     <SortedDescendingCellStyle BackColor="#D6DFDF" />
                     <SortedDescendingHeaderStyle BackColor="#002876" />
                 </asp:GridView>
        </p>
                 <asp:Label ID="Label7" runat="server" Text="Selecciona el encargado de la obra:"></asp:Label>
                 <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                     </Columns>
                     <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                     <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                     <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                     <RowStyle BackColor="White" ForeColor="#003399" />
                     <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                     <SortedAscendingCellStyle BackColor="#EDF6F6" />
                     <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                     <SortedDescendingCellStyle BackColor="#D6DFDF" />
                     <SortedDescendingHeaderStyle BackColor="#002876" />
                 </asp:GridView>
             <p>
                 &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" style="width: 63px" />
        </p>
             <p>
                 <asp:TextBox ID="TextBox4" runat="server" Width="241px"></asp:TextBox>
        </p>
             <p>
                 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar" />
        </p>
             <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                 <Columns>
                     <asp:CommandField ShowSelectButton="True" />
                 </Columns>
                 <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                 <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                 <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                 <RowStyle BackColor="White" ForeColor="#003399" />
                 <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                 <SortedAscendingCellStyle BackColor="#EDF6F6" />
                 <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                 <SortedDescendingCellStyle BackColor="#D6DFDF" />
                 <SortedDescendingHeaderStyle BackColor="#002876" />
             </asp:GridView>
             <br />
             <asp:TextBox ID="TextBox5" runat="server" Width="241px"></asp:TextBox>
        </center>
       
        <div>
        </div>
    </form>
</body>
</html>
