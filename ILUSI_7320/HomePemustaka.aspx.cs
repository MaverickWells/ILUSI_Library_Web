using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ILUSI_7320
{
    public partial class HomePemustaka : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userdata"] == null)
            {
                Label1.Text = string.Empty;

                Response.Redirect("Default.aspx");
            }
            else if (Session["userdata"] is Pemustaka)
            {
                Pemustaka user = Session["userdata"] as Pemustaka;

                Label1.Text = user.Username;
            }
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePemustaka.aspx");

        }

        protected void CekKetersediaan_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewDataCekKetersediaan.aspx");
        }

        protected void BhnPustakaDipinjam_Click(object sender, EventArgs e)
        {
            Response.Redirect("BahanPustakaDipinjam.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove(Label1.Text);
            Session["userdata"] = null;

            Response.Redirect("Default.aspx");
        }
    }
}
