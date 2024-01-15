using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TryFast1.Data;

namespace TryFast1
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
            if (String.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Password tidak boleh kosong");
                return false;
            }else if (String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }
            else
            {
                return true;
            }
        }

        bool emailValid()
        {
            if (!tbEmail.Text.Contains('@'))
            {
                MessageBox.Show("Email tidak valid");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (kosongan() && emailValid())
            {
                Repo.Login(tbEmail.Text, tbPass.Text);
                if (Repo.loggedInUser != null)
                {
                    pindahForm();
                }
                else
                {
                    MessageBox.Show("Akun anda tidak ditemukan");
                }
            }
        }

        void pindahForm()
        {
            this.Hide();
            MainForm Main = new MainForm();
            Main.Show();
        }
    }
}
