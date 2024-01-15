using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFast1.Data
{
    public class Repo
    {
        public static TryFast1Entities entities = new TryFast1Entities();

        public static User loggedInUser = null;
        public static void Login(String email, String pass)
        {
            loggedInUser = entities.Users.Where(r=> r.email.Equals(email) && r.password.Equals(pass)).FirstOrDefault();
        }
        public static void Logout() {
            loggedInUser = null;
        }
    }
}
