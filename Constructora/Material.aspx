<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Material.aspx.cs" Inherits="Constructora.Material" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.4.24/dist/sweetalert2.all.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.4.24/dist/sweetalert2.all.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.4.24/dist/sweetalert2.min.js"></script>
    <script type="text/javascript">
    function Mensaje(t,m,tipo)
    {
            Swal.fire(
                t, m, tipo
            )
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul class="navbar-nav">
                <li class="nav-item"><a class="nav-link" href="Index.aspx">Inicio</a> </li>
                <li class="nav-item"><a class="nav-link" href="Obra.aspx">Obras</a> </li>
                <li class="nav-item"><a class="nav-link" href="ProveedorMaterial.aspx">Proveedora materiales</a> </li>
            </ul>
        </div>
        <center>
             <p>
            <asp:Label ID="Label1" runat="server" Text="Materiales"></asp:Label>
        </p>
             <p>
                 <asp:Label ID="Label2" runat="server" Text="Descripcion de material"></asp:Label>
&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
             <p>
                 <asp:Label ID="Label3" runat="server" Text="Marca"></asp:Label>
&nbsp;&nbsp;
                 <asp:TextBox ID="TextBox2" runat="server" Width="225px"></asp:TextBox>
        </p>
             <p>
                 <asp:Label ID="Label4" runat="server" Text="Presentacion"></asp:Label>
&nbsp;
                 <asp:TextBox ID="TextBox3" runat="server" Width="191px"></asp:TextBox>
        </p>
             <p>
                 <asp:Label ID="Label5" runat="server" Text="Selecciona el tipo de material:"></asp:Label>
        </p>
             <p>
                 <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
        </p>
             <p>
                 <asp:TextBox ID="TextBox4" runat="server" Width="241px"></asp:TextBox>
        </p>
             <p>
                 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
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
       
    </form>
</body>
</html>
