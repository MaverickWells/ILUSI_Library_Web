using ILUSI_7320.DataSetUserTableAdapters;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.UI.HtmlControls;
using System.Data;
using System;

namespace ILUSI_7320
{
    public class UserControl
    {
        TBL_UserTableAdapter TBL_UserAdapter = new TBL_UserTableAdapter();

        public DataTable showUser()
        {
            DataTable DT = null;

            try
            {
                DT = TBL_UserAdapter.GetData();
            }
            catch(Exception e)
            {
                DT = null;
            }

            return DT;
        }
    }
}