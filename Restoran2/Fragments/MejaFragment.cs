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
    public partial class MejaFragment : UserControl
    {
        public MejaFragment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void clearField()
        {
            tbJenis.Clear();
            numKapasitas.Value = 1;
            tbNoMeja.Clear();
            cbStatus.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        void fillDGV()
        {
            this.mejaTableAdapter.Fill(this.restoran2DataSet.Meja);
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbJenis.Text))
            {
                MessageBox.Show("Jenis tidak boleh kosong");
                return false;
            }
            else if (numKapasitas.Value == 0)
            {
                MessageBox.Show("Kapasitas tidak boleh kosong");
                return false;
            }
            else if (String.IsNullOrEmpty(tbNoMeja.Text))
            {
                MessageBox.Show("noMeja tidak boleh kosong");
                return false;
            }
            else if (String.IsNullOrEmpty(cbStatus.Text))
            {
                MessageBox.Show("Status tidak boleh kosong");
                return false;
            }else if (!tbNoMeja.Text.StartsWith("Meja"))
            {
                MessageBox.Show("noMeja tidak valid");
                return false;
            }
            else { return true; }
        }

        void masukin()
        {
            Meja meja = new Meja()
            {
                noMeja = tbNoMeja.Text,
                jenis = tbJenis.Text,
                kapasitas = Convert.ToInt32(numKapasitas.Value),
                status = cbStatus.Text,
            };
            Repo.entities.Mejas.Add(meja);
            if (Repo.konfirmasi())
            {
                Repo.entities.SaveChanges();
                fillDGV();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                masukin();
            }
        }

        private void MejaFragment_Load(object sender, EventArgs e)
        {
            fillDGV();
        }
    }
}
