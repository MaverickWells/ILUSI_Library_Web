using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ILUSI_7320.DataSetUserTableAdapters;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.UI.HtmlControls;

namespace ILUSI_7320
{
    public class LoginUserControl
    {
        TBL_UserTableAdapter TBL_UserAdapter = new TBL_UserTableAdapter();

        public bool cekLogin(string username, string password)
        {
            bool cek = false;

            try
            {
                if (TBL_UserAdapter.GetUsername(username, password).ToString() != "")
                    cek = true;
            }
            catch (Exception e)
            {
                cek = false;
            }

            return cek;
        }

        public int GetRoleUser(string username, string password)
        {
            int role = 0;

            try
            {
                role = int.Parse(TBL_UserAdapter.GetIDRole(username, password).ToString());
            }
            catch (Exception e)
            {
                role = 0;
            }

            return role;
        }
    }
}
