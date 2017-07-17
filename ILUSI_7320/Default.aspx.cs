using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ILUSI_7320
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;

            if (Session["login"] != null)
            {
                if (Session["login"].ToString() == "failed")
                {
                    Label1.Text = "Maaf username atau password anda salah";
                    Label1.Visible = true;

                    Session["login"] = null;
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            LoginUserControl LC = new LoginUserControl();
            LoginPemustakaControl LP = new LoginPemustakaControl();
            LoginKaprodiControl LK = new LoginKaprodiControl();

            if (LC.cekLogin(Login1.UserName, Login1.Password) == true)
            {
                int role = LC.GetRoleUser(Login1.UserName, Login1.Password);

                if (role == 4)
                {
                    User U = new User(Login1.UserName, Login1.Password, role);

                    Session["userdata"] = null;
                    Session.Add("userdata", U);

                    Response.Redirect("HomeKaPus.aspx");
                }
                else if (role >= 5)
                {                    
                    Kaprodi K = new Kaprodi(Login1.UserName, Login1.Password, role, LK.GetIDProdiUser(Login1.UserName, Login1.Password, role));

                    Session["userdata"] = null;
                    Session.Add("userdata", K);

                    Response.Redirect("HomeKaprodi.aspx");
                }
                else
                {
                    Session["login"] = null;
                    Session.Add("login", "failed");

                    Response.Redirect("Default.aspx");
                }
            }
            else if (LP.cekLogin(Login1.UserName, Login1.Password) == true)
            {
                int noAnggota = LP.getNoAnggota(Login1.UserName, Login1.Password);

                if (noAnggota >= 1)
                {
                    Pemustaka P = new Pemustaka(Login1.UserName, Login1.Password, noAnggota);

                    Session["userdata"] = null;
                    Session.Add("userdata", P);

                    Response.Redirect("HomePemustaka.aspx");
                }
                else
                {
                    Session["login"] = null;
                    Session.Add("login", "failed");

                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                Session["login"] = null;
                Session.Add("login", "failed");

                Response.Redirect("Default.aspx");
            }
        }
    }
}
