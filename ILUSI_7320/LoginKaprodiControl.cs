using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ILUSI_7320.DataSetUserTableAdapters;

namespace ILUSI_7320
{
    public class LoginKaprodiControl
    {
        TBL_UserTableAdapter TBL_UserAdapter = new TBL_UserTableAdapter();
        TBL_User_KaprodiTableAdapter TBL_User_Kaprodi = new TBL_User_KaprodiTableAdapter();

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

        public int GetIDProdiUser(string username, string password, int role)
        {
            int prodi = 0;

            try
            {
                prodi = int.Parse(TBL_User_Kaprodi.GetIDProdi(username, password, role).ToString());
            }
            catch (Exception e)
            {
                prodi = 0;
            }

            return prodi;
        }
    }
}
