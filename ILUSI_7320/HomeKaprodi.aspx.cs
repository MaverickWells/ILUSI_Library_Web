using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ILUSI_7320
{
    public partial class HomeKaprodi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userdata"] == null)
            {
                Label1.Text = string.Empty;

                Response.Redirect("Default.aspx");
            }
            else if (Session["userdata"] is Kaprodi)
            {
                Kaprodi user = Session["userdata"] as Kaprodi;

                Label1.Text = user.Username;
            }
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeKaprodi.aspx");
        }

        protected void Report5BP_Click(object sender, EventArgs e)
        {
            Response.Redirect("5BPTersering.aspx");
        }

        protected void Report5Pemustaka_Click(object sender, EventArgs e)
        {
            Response.Redirect("5Pemustaka.aspx");
        }

        protected void ReportRealisasi_Click(object sender, EventArgs e)
        {
            Response.Redirect("RealisasiBPProdi.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove(Label1.Text);
            Session["userdata"] = null;

            Response.Redirect("Default.aspx");
        }
    }
}
