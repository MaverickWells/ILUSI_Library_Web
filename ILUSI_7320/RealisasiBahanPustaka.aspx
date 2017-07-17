﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RealisasiBahanPustaka.aspx.cs" Inherits="ILUSI_7320.RealisasiBahanPustaka" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title></title>
    </head>
    
    <body style="background-image:url('Kapus.jpg'); width:auto">
        <form id="form1" runat="server">
            <center>            
                <asp:Label runat="server" Text="Selamat Datang Di Web Site UJDP" ForeColor="White" Font-Size="Larger"></asp:Label>
                
                <br />
                <br />
                
                <asp:Image ID="Image1" runat="server" ImageUrl="~/UJDP.jpg" />
                
                <br />
                <br />
                
                <asp:Label runat="server" Text="Laporan Realisasi Bahan Pustaka" ForeColor="White"></asp:Label>
            </center>
            
            <br />
            
            <div>
                <center>
                    <asp:Label ID="Label3" runat="server" Text="Username : " ForeColor="White"></asp:Label>
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
                                <button id="btn_reportDendaProdi" style="width: 200px" onserverclick="DendaProdi_Click" runat="server">
                                Laporan Denda Per Prodi</button>
                            </td>
                            <td>
                                <button id="btn_reportDendaBulan" style="width: 200px" onserverclick="DendaBulan_Click" runat="server">
                                Laporan Denda Per Bulan</button>
                            </td>
                            <td>
                                <button id="btn_report20buku" style="width:200px" onserverclick="Report20Buku_Click" runat="server">
                                Laporan 20 Buku Paling Sering Dipinjam</button>
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
                
                <br />
                
                <center>
                    <label style="color:White; padding-right:25px" >Semester </label>
            
                    <asp:DropDownList ID="semester" runat="server" Width="100px">
                        <asp:ListItem>Gasal</asp:ListItem>
                        <asp:ListItem>Genap</asp:ListItem>
                    </asp:DropDownList>
                    
                    <label style="color:White; padding-left:25px; padding-right:25px">Tahun Ajaran</label>
                    
                    <asp:DropDownList ID="TA" runat="server" Width="100px" 
                        DataSourceID="ObjectDataSource1" DataTextField="Tahun" DataValueField="Tahun">
                        <asp:ListItem>2015 / 2016</asp:ListItem>
                    </asp:DropDownList>
                    
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
                        TypeName="ILUSI_7320.DataSetRealisasiBPTableAdapters.TBL_Usulan_Bahan_PustakaTableAdapter">
                    </asp:ObjectDataSource>
                    
                    <button id="btnTampil" runat="server" style="margin-left:30px" onserverclick="btnTampil_Click">Tampilkan</button>
                </center>
                
                <br />
                
                <center>
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
                        ForeColor="#333333" GridLines="None">
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
                                    <%#Container.DataItemIndex + 1 %>
                                </ItemTemplate>

<HeaderStyle Width="20px"></HeaderStyle>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    
                    <br />
                    
                    <button id="btn_cetak" runat="server" onserverclick="Cetak_Click">Cetak Laporan</button>
                </center>
            </div>
        </form>
    </body>
</html>
