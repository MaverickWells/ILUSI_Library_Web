using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ILUSI_7320.DataSetPemustakaTableAdapters;
using ILUSI_7320.DataSetBahanPustakaDipinjamTableAdapters;

namespace ILUSI_7320
{
    public partial class BahanPustakaDipinjam : System.Web.UI.Page
    {
        TBL_PemustakaTableAdapter TP = new TBL_PemustakaTableAdapter();
        TBL_Detil_TransaksiTableAdapter TB = new TBL_Detil_TransaksiTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            Pemustaka user = null;

            if (Session["userdata"] == null)
            {
                Label1.Text = string.Empty;

                Response.Redirect("Default.aspx");
            }
            else
            {
                user = Session["userdata"] as Pemustaka;

                Label1.Text = user.Username;

                Label2.Text = TP.getNoAnggota(user.Username, user.Password).ToString();
            }

            GridView1.DataSource = TB.GetDataBhnPustDipinjam(user.NoAnggota);
            GridView1.DataBind();
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
