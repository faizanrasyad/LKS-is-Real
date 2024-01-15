using Restoran2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran2.Fragments
{
    public partial class HomeFragment : UserControl
    {
        public HomeFragment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void HomeFragment_Load(object sender, EventArgs e)
        {
            label1.Text = "Selamat datang, "+Repo.logged.nama+"!";
        }
    }
}
