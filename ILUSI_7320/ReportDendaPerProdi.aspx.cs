﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ILUSI_7320.DataSetDendaPerProdiTableAdapters;
using CrystalDecisions.CrystalReports.Engine;

namespace ILUSI_7320
{
    public partial class ReportDendaPerProdi : System.Web.UI.Page
    {
        private TBL_Detil_TransaksiTableAdapter TD = new TBL_Detil_TransaksiTableAdapter();
            
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ClientTarget = "uplevel";

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
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeKaPus.aspx");
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

        protected void btnTampil_Click(object sender, EventArgs e)
        {
            string tgl_awal = string.Empty;
            string tgl_akhir = string.Empty;

            if (semester.Text == "Gasal")
            {
                tgl_awal = TA.Text.Substring(0, 4) + "-08-01";
                tgl_akhir = TA.Text.Substring(0, 4) + "-12-31";
            }
            else if (semester.Text == "Genap")
            {
                tgl_awal = TA.Text.Substring(0, 4) + "-01-01";
                tgl_akhir = TA.Text.Substring(0, 4) + "-07-31";
            }

            GridView1.DataSource = TD.GetData(tgl_awal, tgl_akhir);
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

            DT = TD.GetData(tglStart, tglStop);

            RD.Load(Server.MapPath("~/DendaPerProdiReport.rpt"));
            RD.SetDataSource(DT);
            RD.SetParameterValue("semester", semester.Text + " " + TA.Text.Substring(0, 4) + " / " + (int.Parse(TA.Text.Substring(0, 4)) + 1));
            RD.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Response, true, "Laporan Denda Per Prodi");
        }
    }
}
