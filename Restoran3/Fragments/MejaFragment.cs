using Restoran3.Data;
using Restoran3.Data.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran3.Fragments
{
    public partial class MejaFragment : UserControl
    {

        public MejaFragment()
        {
            InitializeComponent();
        }

        void clearField()
        {
            tbJenis.Clear();
            tbNoMeja.Clear();
            numKapasitas.Value = 1;
            cbStatus.Text = string.Empty;

            MejaCRUD.selectedMeja = null;
            btnAdd.Enabled = true;
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbJenis.Text))
            {
                MessageBox.Show("Jenis tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbNoMeja.Text))
            {
                MessageBox.Show("noMeja tidak boleh kosong");
                return false;
            }

            if (cbStatus.Text == String.Empty)
            {
                MessageBox.Show("Status tidak boleh kosong");
                return false;
            }

            if (numKapasitas.Value == 0)
            {
                MessageBox.Show("Kapasitas minimal 1");
                return false;
            }

            if (!tbNoMeja.Text.StartsWith("Meja"))
            {
                MessageBox.Show("idMeja tidak valid");
                return false;
            }

            return true;
        }

        void populate(Meja meja)
        {
            tbJenis.Text = meja.Jenis;
            tbNoMeja.Text = meja.noMeja;
            cbStatus.Text = meja.Status;
            numKapasitas.Value = meja.Kapasitas;
        }

        void fillDGV()
        {
            this.mejaTableAdapter.Fill(this.restoran3DataSet.Meja);
        }

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if (Repo.konfirmasi())
                {
                    MejaCRUD.addMeja(tbNoMeja.Text, tbJenis.Text, Convert.ToInt32(numKapasitas.Value), cbStatus.Text);
                    fillDGV();
                    clearField();
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (valid() && MejaCRUD.selectedMeja != null)
            {

                MejaCRUD.selectedMeja.Jenis = tbJenis.Text;
                MejaCRUD.selectedMeja.Kapasitas = Convert.ToInt32(numKapasitas.Value);
                MejaCRUD.selectedMeja.noMeja = tbNoMeja.Text;
                MejaCRUD.selectedMeja.Status = cbStatus.Text;

                if (Repo.konfirmasi())
                {
                    MejaCRUD.updateMeja(MejaCRUD.selectedMeja);
                    fillDGV();
                    clearField() ;
                }
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                if (MejaCRUD.selectedMeja != null)
                {
                    MejaCRUD.removeMeja();
                    fillDGV();
                    clearField();
                }
                
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                MejaCRUD.exportMeja(this.restoran3DataSet.Meja);
            }
        }
        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnAdd.Enabled = false;
                var selMeja = new Meja();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    selMeja.noMeja = row.Cells["noMeja"].Value.ToString();
                    selMeja.Jenis = row.Cells["jenis"].Value.ToString();
                    selMeja.Status = row.Cells["status"].Value.ToString();
                    selMeja.Kapasitas = Convert.ToInt32(row.Cells["kapasitas"].Value);
                }

                populate(selMeja);

                MejaCRUD.selectedMeja = selMeja;
            }
        }

        private void MejaFragment_Load(object sender, EventArgs e)
        {
            clearField();
            fillDGV();
        }
    }
}
