using Restoran1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran1.ui.fragments
{
    public partial class MainFragment : UserControl
    {
        public MainFragment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text ="Selamat datang, "+ Repo.loggedInUser.nama+ "!";
        }
    }
}
