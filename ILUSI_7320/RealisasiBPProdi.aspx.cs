using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ILUSI_7320.DataSetRealisasiProdiTableAdapters;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;

namespace ILUSI_7320
{
    public partial class RealisasiBPProdi : System.Web.UI.Page
    {
        private TBL_Detil_Usulan_Bahan_PustakaTableAdapter TB = new TBL_Detil_Usulan_Bahan_PustakaTableAdapter();
        private TBL_ProdiTableAdapter TP = new TBL_ProdiTableAdapter();
        private Kaprodi user;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userdata"] == null)
            {
                Label1.Text = string.Empty;

                Response.Redirect("Default.aspx");
            }
            else if (Session["userdata"] is Kaprodi)
            {
                user = Session["userdata"] as Kaprodi;

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

        protected void btnTampil_Click(object sender, EventArgs e)
        {
            string tglStart = string.Empty, tglStop = string.Empty;

            if (semester.Text == "Gasal")
            {
                tglStart = TA.Text.Substring(0, 4) + "-08-01";
                tglStop = TA.Text.Substring(0, 4) + "-12-31";
            }
            else if (semester.Text == "Genap")
            {
                tglStart = TA.Text.Substring(0, 4) + "-01-01";
                tglStop = TA.Text.Substring(0, 4) + "-07-31";
            }

            GridView1.DataSource = TB.GetDataUsulanProdi(tglStart, tglStop, user.KodeProdi);
            GridView1.DataBind();
        }

        protected void Cetak_Click(object sender, EventArgs e)
        {
            ReportDocument RD = new ReportDocument();

            DataTable DT = new DataTable();

            string tglStart = string.Empty, tglStop = string.Empty;

            if (semester.Text == "Gasal")
            {
                tglStart = TA.Text.Substring(0, 4) + "-08-01";
                tglStop = TA.Text.Substring(0, 4) + "-12-31";
            }
            else if (semester.Text == "Genap")
            {
                tglStart = TA.Text.Substring(0, 4) + "-01-01";
                tglStop = TA.Text.Substring(0, 4) + "-07-31";
            }

            DT = TB.GetDataUsulanProdi(tglStart, tglStop, user.KodeProdi);

            RD.Load(Server.MapPath("~/ReportRealisasiProdi.rpt"));
            RD.SetDataSource(DT);
            RD.SetParameterValue("prodi", TP.GetNamaProdi(user.KodeProdi));
            RD.SetParameterValue("semester", semester.Text + " " + TA.Text + " / " + (int.Parse(TA.Text) + 1));
            RD.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Laporan Realisasi Bahan Pustaka");
        }
    }
}
