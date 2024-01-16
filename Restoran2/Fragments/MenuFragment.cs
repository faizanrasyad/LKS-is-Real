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
    public partial class MenuFragment : UserControl
    {
        public MenuFragment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        void clearField()
        {
            cbJenis.Text = string.Empty;
            tbHarga.Clear();
            tbIdMenu.Clear();
            tbNama.Clear();
        }

        void fillDGV()
        {
            this.menuTableAdapter.Fill(this.restoran2DataSet.Menu);
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(cbJenis.Text))
            {
                MessageBox.Show("Jenis tidak boleh kosong");
                return false;

            } else if (String.IsNullOrEmpty(tbHarga.Text))
            {
                MessageBox.Show("Harga tidak boleh kosong");
                return false;

            } else if (String.IsNullOrEmpty(tbIdMenu.Text))
            {
                MessageBox.Show("idMenu tidak boleh kosong");
                return false;

            } else if (String.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return false;

            } else if (!tbIdMenu.Text.StartsWith("Menu"))
            {
                MessageBox.Show("idMenu tidak valid");
                return false;
            } else if (Convert.ToInt32(tbHarga.Text) < 1000)
            {
                MessageBox.Show("Harga tidak boleh dibawah 1000");
                return false;
            }
            else
            {
                return true;
            }
        }

        void masukin()
        {
            Menu menu = new Menu()
            {
                idMenu = tbIdMenu.Text,
                harga = Convert.ToInt32(tbHarga.Text),
                jenis = cbJenis.Text,
                nama = tbNama.Text,
            };
            Repo.entities.Menus.Add(menu);
            if (Repo.konfirmasi())
            {
                Repo.entities.SaveChanges();
                fillDGV();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                masukin();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void transaksiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void menuBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuFragment_Load(object sender, EventArgs e)
        {
            fillDGV();
        }
    }
}
