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

namespace Restoran2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logiun = new Form1();
            logiun.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setupView();
        }

        void hideAllFragment()
        {
            foreach (UserControl fragments in fragmentContainer.Controls)
            {
                fragments.Visible = false;
            }
        }

        void showFragment(UserControl fragment)
        {
            hideAllFragment();
            fragment.Visible = true;

        }

        void setupView()
        {
            label1.Text = Repo.logged.email;
            hideAllFragment();
            showFragment(homeFragment1);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setupView();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showFragment(customerFragment1);
        }

        private void btnMeja_Click(object sender, EventArgs e)
        {
            showFragment(mejaFragment1);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showFragment(menuFragment1);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            showFragment(transaksiFragment1);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showFragment(reportFragment1);
        }
    }
}
