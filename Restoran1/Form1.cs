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
    public partial class Form1 : Form
    {
        bool gantian = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        bool kosongan()
        {
            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }else if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Password tidak boleh kosong");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            if (gantian)
            {
                btnLihat.Text = "Sembunyikan";
               

            }
            else
            {
                btnLihat.Text = "Lihat";
            }
            gantian =!gantian;
            tbPass.UseSystemPasswordChar = gantian;
        }

        void pindahMain()
        {
            this.Hide();
            MainForm main  = new MainForm();
            main.Show();
        }

        bool validateEmail()
        {
            if (tbEmail.Text.Contains('@'))
            {
                return true;
            }else { MessageBox.Show("Email tidak valid"); return false; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (kosongan() && validateEmail())
            {
                Repo.Login(tbEmail.Text, tbPass.Text);
                if (Repo.loggedInUser != null)
                {
                    pindahMain();
                }
                else
                {
                    MessageBox.Show("Akun tidak ditemukan");
                }
            }
            else
            {
                
            }
        }
    }
}
