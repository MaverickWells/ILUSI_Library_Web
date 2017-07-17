using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ILUSI_7320.DataSetPemustakaTableAdapters;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.UI.HtmlControls;

namespace ILUSI_7320
{
    public class LoginPemustakaControl
    {
        TBL_PemustakaTableAdapter TBL_PemustakaAdapter = new TBL_PemustakaTableAdapter();

        public bool cekLogin(string username, string password)
        {
            bool cek = false;

            try
            {
                if (TBL_PemustakaAdapter.getPemustaka(username, password).ToString() != "")
                    cek = true;
            }
            catch (Exception e)
            {
                cek = false;
            }

            return cek;
        }

        public int getNoAnggota(string username, string password)
        {
            int noAnggota = 0;

            try
            {
                noAnggota = int.Parse(TBL_PemustakaAdapter.getNoAnggota(username, password).ToString());
            }
            catch (Exception e)
            {
                noAnggota = 0;
            }

            return noAnggota;
        }
    }
}
