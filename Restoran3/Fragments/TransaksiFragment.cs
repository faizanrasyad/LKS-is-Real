using DocumentFormat.OpenXml.Spreadsheet;
using Restoran3.Data;
using Restoran3.Data.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran3.Fragments
{
    public partial class TransaksiFragment : UserControl
    {
        public TransaksiFragment()
        {
            InitializeComponent();
        }

        void clearField()
        {
           
            tbidMenu.Clear();
            tbIdCustomer.Clear();
            tbidMenu.Clear();
            tbIdUser.Clear();
            tbPaid.Clear();
            tbTotal.Clear();
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbIdCustomer.Text))
            {
                MessageBox.Show("idCustomer tidak boleh kosong");
                return false;
            }

            /*if (String.IsNullOrEmpty (tbIdTransaksi.Text))
            {
                MessageBox.Show("idCustomer tidak boleh kosong");
                return false;
            }*/

            if(String.IsNullOrEmpty(tbidMenu.Text))
            {
                MessageBox.Show("idCustomer tidak boleh kosong");
                return false;
            }

            if(String.IsNullOrEmpty (tbIdUser.Text)) 
            {
                MessageBox.Show("idCustomer tidak boleh kosong");
                return false;
            }

            return true;
        }

        void fillComboBoxMeja()
        {
            cbMeja.DataSource = Repo.entities.Mejas.Where(r=> r.Status.Equals("Tersedia")).ToList(); 
            cbMeja.ValueMember = "noMeja";
            cbMeja.DisplayMember = "noMeja";
        }
        void fillComboBoxCustomer()
        {
            cbCustomer.DataSource = Repo.entities.Customers.ToList();
            cbCustomer.ValueMember = "idCustomer";
            cbCustomer.DisplayMember = "Nama";
        }

        void fillDGVMenu()
        {
            if(TransaksiCRUD.listSelectedMenu.Count > 0)
            {
                Restoran3DataSet.MenuDataTable listMenu = new Restoran3DataSet.MenuDataTable();

                var listFilteredMenu = this.restoran3DataSet.Menu.Where(
                    menu => TransaksiCRUD.listSelectedMenu.All(selected => selected.idMenu != menu.idMenu)
                    );

                foreach (var menuRow in listFilteredMenu)
                {
                    // Create a new row in your target DataTable
                    Restoran3DataSet.MenuRow newRow = listMenu.NewMenuRow();

                    // Copy the values from the source row to the new row
                    newRow.idMenu = menuRow.idMenu;
                    newRow.Nama = menuRow.Nama;
                    newRow.Harga = menuRow.Harga;
                    newRow.Jenis = menuRow.Jenis;
                    // Copy other columns as needed

                    // Add the new row to the target DataTable
                    listMenu.Rows.Add(newRow);
                }

                Debug.Print(listMenu.ToString());
                this.menuTableAdapter.Fill(
                    listMenu
                    );
            }
            else
            {
                this.menuTableAdapter.Fill(
                    this.restoran3DataSet.Menu 
                    );
            }
            
        }

        int a = 0;
        void fillDGVItemTransaksi()
        {
            

            List<DataGridViewRow> rowsList = new List<DataGridViewRow>();

            for (int n = a; n < TransaksiCRUD.listSelectedMenu.Count; n ++)
            {
                var idMenu = TransaksiCRUD.listSelectedMenu[n].idMenu;
                Menu menu = MenuCRUD.getById(idMenu);

                if (menu != null)
                {
                    rowsList.Add(new DataGridViewRow());
                    rowsList[rowsList.Count - 1].CreateCells(dataGridView2,
                        menu.idMenu,
                        menu.Nama,
                        menu.Harga,
                         TransaksiCRUD.listSelectedMenu[n].qty,
                        menu.Jenis);
                }
                a += 1;
            }
           

            /*
            foreach (itemTransaksi IT in TransaksiCRUD.listSelectedMenu)
            {
                var idMenu = IT.idMenu;
                Menu menu = MenuCRUD.getById(idMenu);

                if (menu != null)
                {
                    rowsList.Add(new DataGridViewRow());
                    rowsList[rowsList.Count - 1].CreateCells(dataGridView2,
                        menu.idMenu,
                        menu.Nama,
                        menu.Harga,
                        IT.qty,
                        menu.Jenis);
                }
            }*/

            dataGridView2.Rows.AddRange(rowsList.ToArray());
        }

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                //todo
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                //todo
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                //todo
            }
        }
        #endregion

        private void TransaksiFragment_Load(object sender, EventArgs e)
        {
            clearField();
            fillComboBoxMeja();
            fillComboBoxCustomer();
            fillDGVMenu();
        }

        private void cbMeja_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbMeja.);
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransaksiFragment_VisibleChanged(object sender, EventArgs e)
        {
            fillComboBoxMeja();
            fillComboBoxCustomer();
            fillDGVMenu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnToItemTransaksi.Enabled = true;
                btnToMenu.Enabled = false;
                var rowIndex = e.RowIndex;
                var selMenu = new Menu();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    selMenu.Jenis = row.Cells["jenisMenu"].Value.ToString();
                    selMenu.idMenu = row.Cells["idMenu"].Value.ToString();
                    selMenu.Harga = Convert.ToInt32(row.Cells["hargaMenu"].Value);
                    selMenu.Nama = row.Cells["namaMenu"].Value.ToString();
                }

                //populate(selMenu);
                TransaksiCRUD.tempSelectedMenuIndex = rowIndex;
                TransaksiCRUD.tempSelectedMenu = selMenu;
            }
        }

        private void btnToItemTransaksi_Click(object sender, EventArgs e)
        {
            if (TransaksiCRUD.tempSelectedMenu != null)
            {
                itemTransaksi IT = new itemTransaksi();
                IT.qty = Convert.ToInt32(numQuantity.Value);
                IT.idMenu = TransaksiCRUD.tempSelectedMenu.idMenu;
                Debug.Print("List Selected menu before add : " + TransaksiCRUD.listSelectedMenu.Count.ToString());
                TransaksiCRUD.listSelectedMenu.Add(IT);
                Debug.Print("List Selected menu after add : " + TransaksiCRUD.listSelectedMenu.Count.ToString());

                fillDGVItemTransaksi();
                dataGridView1.Rows.RemoveAt(TransaksiCRUD.tempSelectedMenuIndex);

                numQuantity.Value = 1;
            }
            

        }

        private void btnToMenu_Click(object sender, EventArgs e)
        {
            int selectedItemIndex = TransaksiCRUD.listSelectedMenu.FindIndex(x => x.idMenu == TransaksiCRUD.tempSelectedMenu.idMenu);
            Debug.Print("List Selected menu index : " +  selectedItemIndex);        
            Debug.Print("Temp Selected menu index : " +  TransaksiCRUD.tempSelectedMenuIndex);        
            Debug.Print("List Selected menu before : " +  TransaksiCRUD.listSelectedMenu.Count.ToString());        
            if(selectedItemIndex != -1)
            {
             
                TransaksiCRUD.listSelectedMenu.RemoveAt(selectedItemIndex);
            }
            dataGridView2.Rows.RemoveAt(TransaksiCRUD.tempSelectedMenuIndex);

            Debug.Print("List Selected menu after : " + TransaksiCRUD.listSelectedMenu.Count);

            fillDGVMenu();
            fillDGVItemTransaksi();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                btnToItemTransaksi.Enabled = false;
                btnToMenu.Enabled = true;

                var rowIndex = e.RowIndex;
                
                var idMenu = dataGridView2.SelectedRows[0].Cells["idMenuItemTransaksi"].Value.ToString();
                Menu selMenu = MenuCRUD.getById(idMenu);

                if (selMenu != null)
                {
                    TransaksiCRUD.tempSelectedMenuIndex = rowIndex;
                    TransaksiCRUD.tempSelectedMenu = selMenu;
                }
                

                //populate(selMenu);
                
            }
        }
    }
}
