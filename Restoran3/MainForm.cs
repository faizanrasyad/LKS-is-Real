using DocumentFormat.OpenXml.Drawing.Diagrams;
using Restoran3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void setupView()
        {
            label1.Text = Repo.logged.Email;
            showFragment(homefragment1);
            hideAllFragment();
            if(Repo.logged.Role == "Pegawai")
            {
                hideAllButton();
            }
        }


        void hideAllFragment()
        {
            foreach(UserControl fragments in fragmentContainer.Controls)
            {
                fragments.Visible = false;
            }
        }

        void showFragment(UserControl fragment)
        {
            hideAllFragment();
            fragment.Visible = true;
        }

        void hideAllButton()
        {
            btnCustomer.Visible = false;
            btnMeja.Visible = false;
            btnMenu.Visible = false;
            btnReport.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setupView();
        }

        #region buttons
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 logun = new Form1();
            logun.Show();
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

        private void Report_Click(object sender, EventArgs e)
        {
            showFragment(reportFragment1);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            setupView();
        }

        #endregion
    }
}
