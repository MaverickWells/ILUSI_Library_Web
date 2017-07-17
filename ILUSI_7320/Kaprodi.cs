using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ILUSI_7320
{
    public class Kaprodi
    {
        private string username, password;
        private int role, kode_prodi;

        public Kaprodi() { }

        public Kaprodi(string username, string password, int role, int kode_prodi)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.kode_prodi = kode_prodi;
        }

        public string Username
        {
            set { username = value; }
            get { return username; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public int Role
        {
            set { role = value; }
            get { return role; }
        }

        public int KodeProdi
        {
            set { kode_prodi = value; }
            get { return kode_prodi; }
        }
    }
}
