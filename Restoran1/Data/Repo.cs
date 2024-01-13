using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran1.Data
{
    public class Repo
    {
        public static Restoran1Entities db = new Restoran1Entities();

        public static User loggedInUser = null;
        public static void Login(String email, String pass)
        {
            loggedInUser = db.Users.Where(user=> user.email.Equals(email) && user.password.Equals(pass)).FirstOrDefault();
        }
        public static void Logout() 
        {
            loggedInUser = null;
        }
    }
}
