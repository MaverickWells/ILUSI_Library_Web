<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BahanPustakaDipinjam.aspx.cs" Inherits="ILUSI_7320.BahanPustakaDipinjam" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <%--<script type="text/javascript" src="/JS/jquery.min.js"></script>
    <style type="text/css">
            .sticky
            {
                position: fixed;
                width: 100%;
                left: 0;
                top: 0;
                z-index: 100;
                border-top: 0;
            }
            
            .nav
            {
                background-color: Maroon;
            }
        </style>
        
        <script type="text/javascript">
            $(document).ready(function() {
                var stickyNavTop = $('.nav').offset().top;

                var stickyNav = function() {
                    var scrollTop = $(window).scrollTop();

                    if (scrollTop > stickyNavTop) {
                        $('.nav').addClass('sticky');
                    } else {
                        $('.nav').removeClass('sticky');
                    }
                };

                stickyNav();

                $(window).scroll(function() {
                    stickyNav();
                });
            });
            
        </script>--%>
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
            
            <asp:Label runat="server" Text="Bahan Pustaka Yang Sedang Dipinjam" ForeColor="White"></asp:Label>
        </center>
       
        <br />
        <div>    
            <center>
                <asp:Label runat="server" Text="Username : " ForeColor="White"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="White"></asp:Label>
                <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
            </center>
            <br />
            <br />
            
            <div>
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
            </div>
        <br />
                <center>
                    <asp:GridView ID="GridView1" runat="server"
                    CellPadding="4" ForeColor="#333333" 
                    GridLines="None">
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
                </center>
        <br />
        
        </div>
    </form>
</body>
</html>
