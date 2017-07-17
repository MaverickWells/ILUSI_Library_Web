using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ILUSI_7320
{
    public partial class HomeKaPus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userdata"] == null)
            {
                Label1.Text = string.Empty;

                Response.Redirect("Default.aspx");
            }
            else if (Session["userdata"] is User)
            {
                User user = Session["userdata"] as User;

                Label1.Text = user.Username;
            }
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeKapus.aspx");
        }

        protected void DendaProdi_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportDendaPerProdi.aspx");
        }

        protected void DendaBulan_Click(object sender, EventArgs e)
        {
            Response.Redirect("DendaProdiPerBulan.aspx");
        }

        protected void Report20Buku_Click(object sender, EventArgs e)
        {
            Response.Redirect("Report20BukuSeringDipinjam.aspx");
        }

        protected void ReportRealisasi_Click(object sender, EventArgs e)
        {
            Response.Redirect("RealisasiBahanPustaka.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove(Label1.Text);
            Session["userdata"] = null;

            Response.Redirect("Default.aspx");
        }
    }
}
