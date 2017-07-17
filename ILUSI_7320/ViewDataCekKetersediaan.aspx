<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewDataCekKetersediaan.aspx.cs" Inherits="ILUSI_7320.ViewData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('Pemustaka.jpg'); width:auto">
    <form id="form1" runat="server">
    <center>
            
            <asp:Label runat="server" Text="Selamat Datang Di Web Site UJDP" ForeColor="White" Font-Size="Larger"></asp:Label>
            
            <br />
            <br />
            
            <asp:Image ID="Image1" runat="server" ImageUrl="~/UJDP.jpg" />
            
            <br />
            <br />
            
            <asp:Label runat="server" Text="Cek Ketersediaan Bahan Pustaka" ForeColor="White"></asp:Label>
    </center>
    <br />
    <div>
    
        <center>
                <asp:Label runat="server" Text="Username : " ForeColor="White"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White"></asp:Label>
        </center>
        <br />
        <br />
        <center><table style="width: 42%; margin-bottom: 0px;">
                <tr>
                    <td>
                        <button id="btn_home" style="width: 200px" onserverclick="Home_Click" runat="server">Home</button>
                    </td>
                    <td>
                        <button id="btn_cekKetersediaan" style="width: 200px" onserverclick="CekKetersediaan_Click" runat="server">
                        Cek Ketersediaan Bahan Pustaka</button>
                    </td>
                    <td>
                        <button id="btn_bhnPustakaDipinjam" style="width: 200px" onserverclick="BhnPustakaDipinjam_Click" runat="server">
                        Bahan Pustaka Sedang Dipinjam</button>
                    </td>
                    <td>
                        <button id="btn_logout" style="width: 200px" onserverclick="Logout_Click" runat="server">Log Out</button>
                    </td>
                </tr>           
            </table></center> 
        
        <br />
        <br />
        
            <center>
                <table>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="Label2" style="color:White" runat="server">PENCARIAN BAHAN PUSTAKA</asp:Label>
                        </td>                        
                    </tr>
                    <tr>
                        <td style="padding-right:10px"><asp:Label Text="Judul Bahan Pustaka :" runat="server" ForeColor="White"></asp:Label></td>
                        <td style="padding-left:10px; padding-right:10px">
                            <asp:TextBox ID="Judul" Width="200px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="padding-right:10px"><asp:Label Text="Pengarang :" runat="server" ForeColor="White"></asp:Label></td>
                        <td style="padding-left:10px; padding-right:10px">
                            <asp:TextBox ID="Pengarang" Width="200px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="padding-right:10px"><asp:Label Text="Penerbit :" runat="server" ForeColor="White"></asp:Label></td>
                        <td style="padding-left:10px; padding-right:10px">
                            <asp:TextBox ID="Penerbit" Width="200px" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>                        
                        <td colspan="2">
                            <button id="btn_cari" runat="server" onserverclick="btnCari_Click" style="padding-left:10px; width:auto">
                                Cari Bahan Pustaka</button>
                        </td>
                    </tr>
                </table>
            
                <br />
            
                <asp:Label runat="server" Text="HASIL PENCARIAN BAHAN PUSTAKA" ForeColor="White"></asp:Label>
            
                <br />
                <br />
                
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" 
                    onpageindexchanging="GridView1_PageIndexChanging">
                    <PagerSettings Mode="NumericFirstLast" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    
                    <Columns>
                        <asp:TemplateField HeaderText="No." HeaderStyle-Width="20px">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                            <HeaderStyle Width="20px"></HeaderStyle>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            
                <br />
                
                <button id="cetak" runat="server" style="margin-right:15px" onserverclick="btn_cetak_click">Cetak Hasil</button>
                <button id="tutup" runat="server" onserverclick="btn_close_click">Tutup Halaman</button>
                
        </center>    
    </div>
    </form>
</body>
</html>
