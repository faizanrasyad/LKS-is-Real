using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran2.Data
{
    public class Repo
    {
        public static Restoran2Entities entities = new Restoran2Entities();
        public static User logged = null;

        public static void Login(String email, String Pass)
        {
            logged = entities.Users.Where(r=> r.email.Equals(email)&& r.password.Equals(Pass)).FirstOrDefault();
        }
        public static void Logout() {
            logged = null;
        }

        public static bool konfirmasi()
        {
            var result = MessageBox.Show("Apakah anda yakin?", "Konfirmasi Aksi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                return true;
            }else { return false; }
        }
       
    }
}
