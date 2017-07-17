<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeKaprodi.aspx.cs" Inherits="ILUSI_7320.HomeKaprodi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title></title>
        
    </head>
    
    <body style="background-image:url('Kaprodi.jpg'); background-position:right; width:auto">
        <form id="form1" runat="server">
            <center>            
                <asp:Label runat="server" Text="Selamat Datang Di Web Site UJDP" ForeColor="White" Font-Size="Larger"></asp:Label>
                
                <br />
                <br />
                
                <asp:Image ID="Image1" runat="server" ImageUrl="~/UJDP.jpg" />
                
                <br />
                <br />
                
                <asp:Label runat="server" Text="Halaman Utama" ForeColor="White"></asp:Label>
            </center>
        
            <br />
            
            <div>
                <center>
                    <asp:Label runat="server" Text="Username : " ForeColor="White"></asp:Label>
                    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White"></asp:Label>
                </center>
                
                <br />
                <br />
                
                <center>
                    <table style="width: 42%; margin-bottom: 0px;">
                            <tr>
                                <td>
                                    <button id="btn_home" style="width: 200px" onserverclick="Home_Click" runat="server">Home</button>
                                </td>
                                <td>
                                    <button id="btn_report5buku" style="width: 200px" onserverclick="Report5BP_Click" runat="server">
                                    Laporan 5 Buku Paling Sering Dipinjam</button>
                                </td>
                                <td>
                                    <button id="btn_report5pemustaka" style="width: 200px" onserverclick="Report5Pemustaka_Click" runat="server">
                                    Laporan 5 Mahasiswa dan 5 Dosen Paling Aktif</button>
                                </td>
                                <td>
                                    <button id="btn_realisasiBP" style="width:200px" onserverclick="ReportRealisasi_Click" runat="server">
                                    Laporan Realisasi Bahan Pustaka</button>
                                </td>
                                <td>
                                    <button id="btn_logout" style="width: 200px" onserverclick="Logout_Click" runat="server">Log Out</button>
                                </td>
                            </tr>          
                    </table>
                </center> 
            </div>
        </form>
    </body>
</html>
