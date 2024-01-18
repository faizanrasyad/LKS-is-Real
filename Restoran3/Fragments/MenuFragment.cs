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
    public partial class MenuFragment : UserControl
    {
        public MenuFragment()
        {
            InitializeComponent();
        }

        void clearField()
        {
            tbHarga.Clear();
            tbIdMenu.Clear();
            tbNama.Clear();
            cbJenis.Text = String.Empty;

            btnAdd.Enabled = true;
            MenuCRUD.selectedMenu = null;
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbHarga.Text))
            {
                MessageBox.Show("Harga tidak boleh kosong");
                return false;
            }
            
            /*if (String.IsNullOrEmpty(tbIdMenu.Text))
            {
                MessageBox.Show("idMenu tidak boleh kosong");
                return false;
            }*/

            if (String.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(cbJenis.Text))
            {
                MessageBox.Show("Jenis tidak boleh kosong");
                return false;
            }

            if (Convert.ToInt32(tbHarga.Text) == 0)
            {
                MessageBox.Show("Harga tidak valid");
                return false;

            }

            /*if (!tbIdMenu.Text.StartsWith("Menu"))
            {
                MessageBox.Show("idMenu tidak valid");
                return false;
            }*/

            return true;
        }

        void populate(Menu menu)
        {
            tbHarga.Text = menu.Harga.ToString();
            tbIdMenu.Text = menu.idMenu;
            tbNama.Text = menu.Nama;
            cbJenis.Text = menu.Jenis;
        }

        void fillDGV()
        {
            this.menuTableAdapter.Fill(this.restoran3DataSet.Menu);
        }

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if (Repo.konfirmasi())
                {
                MenuCRUD.addMenu(GeneratorId.generateId("Menu"), cbJenis.Text, tbNama.Text, Convert.ToInt32(tbHarga.Text));
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
            if (valid() && MenuCRUD.selectedMenu!= null)
            {

                MenuCRUD.selectedMenu.Harga = Convert.ToInt32(tbHarga.Text);
                MenuCRUD.selectedMenu.idMenu = tbIdMenu.Text;
                MenuCRUD.selectedMenu.Jenis = cbJenis.Text;
                MenuCRUD.selectedMenu.Nama = tbNama.Text;

                if (Repo.konfirmasi())
                {
                    MenuCRUD.updateMenu(MenuCRUD.selectedMenu);
                    fillDGV();
                    clearField() ;
                }
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                MenuCRUD.removeMenu();
                fillDGV();
                clearField();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                MenuCRUD.exportMenu(this.restoran3DataSet.Menu);
            }
        }
        #endregion

        private void MenuFragment_Load(object sender, EventArgs e)
        {
            clearField() ;
            fillDGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnAdd.Enabled = false;
                var selMenu = new Menu();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    selMenu.Jenis = row.Cells["jenis"].Value.ToString();
                    selMenu.idMenu = row.Cells["idMenu"].Value.ToString();
                    selMenu.Harga = Convert.ToInt32(row.Cells["harga"].Value);
                    selMenu.Nama = row.Cells["nama"].Value.ToString();
                }

                populate(selMenu);

                MenuCRUD.selectedMenu = selMenu;
            }
        }
    }
}
