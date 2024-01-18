using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran3.Data
{
    public class Repo
    {
        public static Restoran3Entities entities = new Restoran3Entities();
        public static User logged = null;

        public static void login(String email, String pass)
        {
            String paxx = Enkripsi.encrypt(pass);            
            logged = entities.Users.Where(r=> r.Email.Equals(email) && r.Password.Equals(paxx)).FirstOrDefault();
            User us = entities.Users.Where(r => r.Email.Equals(email)).FirstOrDefault();
            Debug.Print(paxx);
            Debug.Print(us.Password);
        }
        public static void logout() 
        { 
            logged = null;
        }

        public static bool konfirmasi()
        {
            var confirm = MessageBox.Show("Apakah anda yakin?", "Konfirmasi Aksi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}
