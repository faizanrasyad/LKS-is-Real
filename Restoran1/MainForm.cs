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

namespace Restoran1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login  = new Form1();
            login.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        void setupView()
        {
            lblEmail.Text = Repo.loggedInUser.email;
            showFragment(mainFragment1);
        }

        void hideAllFragment()
        {
            foreach(UserControl fragmentitem in fragmentContainer.Controls) 
            { 
                fragmentitem.Visible = false;
            }
        }

        void showFragment(UserControl fragment)
        {
            hideAllFragment();
            fragment.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setupView();
        }

        private void btnKustomer_Click(object sender, EventArgs e)
        {
            showFragment();
        }
    }
}
