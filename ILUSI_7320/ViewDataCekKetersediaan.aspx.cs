using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ILUSI_7320.DataSetBahanPustakaTableAdapters;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace ILUSI_7320
{
    public partial class ViewData : System.Web.UI.Page
    {
        TBL_Bahan_PustakaTableAdapter TBL_Bhn_Pust_Adapter = new TBL_Bahan_PustakaTableAdapter();

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
            else
            {
                Pemustaka user = Session["userdata"] as Pemustaka;

                Label1.Text = user.Username;
            }

            GridView1.DataSource = TBL_Bhn_Pust_Adapter.GetDataBahanPustaka("", "", "");
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

        protected void btn_close_click(object sender, EventArgs e)
        {
            Logout_Click(sender, e);
        }

        protected void btn_cetak_click(object sender, EventArgs e)
        {
            ReportDocument RD = new ReportDocument();

            DataTable DT = new DataTable();

            //DT = TB.GetDataRealisasi(tglStart, tglStop);

            RD.Load(Server.MapPath("~/CetakCekKetersediaan.rpt"));
            RD.SetDataSource(GridView1.DataSource);
            RD.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Cek Ketersediaan Bahan Pustaka");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove(Label1.Text);
            Session["userdata"] = null;

            Response.Redirect("Default.aspx");
        }

        protected void btnCari_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = TBL_Bhn_Pust_Adapter.GetDataBahanPustaka(Judul.Text, Pengarang.Text, Penerbit.Text);
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }


    }
}
