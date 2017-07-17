using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ILUSI_7320
{
    public class Pemustaka
    {
        private string username, password;
        private int noAnggota;

        public Pemustaka() { }

        public Pemustaka(string username, string password, int noAnggota)
        {
            this.username = username;
            this.password = password;
            this.noAnggota = noAnggota;
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

        public int NoAnggota
        {
            set { noAnggota = value; }
            get { return noAnggota; }
        }
    }
}
