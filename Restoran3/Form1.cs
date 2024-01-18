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
    public partial class Form1 : Form
    {
        bool gantian = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            if (gantian == false)
            {
                btnLihat.Text = "Sembunyikan";
                tbPass.UseSystemPasswordChar = gantian;
            }
            else
            {
                btnLihat.Text = "Lihat";
                tbPass.UseSystemPasswordChar = gantian;
            }
            gantian = !gantian;
        }

        bool kosongan()
        {
            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }
            
            if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Password tidak boleh kosong");
                return false;
            }

            return true;
        }

        void pindahForm()
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        bool emailValid()
        {
            if (!tbEmail.Text.Contains('@'))
            {
                MessageBox.Show("Email tidak valid");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (kosongan() && emailValid())
            {
                Repo.login(tbEmail.Text, tbPass.Text);
                if (Repo.logged != null)
                {
                    pindahForm();
                }
                else
                {
                    MessageBox.Show("Akun tidak ditemukan");
                }
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
