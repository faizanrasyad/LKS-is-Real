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
    public partial class CustomerFragment : UserControl
    {
        public CustomerFragment()
        {
            InitializeComponent();
        }

        void clearField()
        {
            tbEmail.Clear();
            tbIdCustomer.Clear();
            tbNama.Clear();
            tbTelp.Clear();
            btnAdd.Enabled = true;
            CustomerCRUD.selectedCust = null;
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }

            /*if (String.IsNullOrEmpty(tbIdCustomer.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }*/

            if (String.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbTelp.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }

            if (!tbEmail.Text.Contains('@'))
            {
                MessageBox.Show("Email tidak valid");
                return false;
            }

            /*if (!tbIdCustomer.Text.StartsWith("Cust"))
            {
                MessageBox.Show("idCustomer tidak valid");
                return false;
            }*/

            if (tbTelp.Text.Length < 10 || !tbTelp.Text.StartsWith("08"))
            {
                MessageBox.Show("Telepon tidak valid");
                return false;
            }

            return true;
        }

        void populate(Customer cust)
        {
            tbEmail.Text = cust.Email;
            tbIdCustomer.Text = cust.idCustomer;
            tbNama.Text = cust.Nama;
            tbTelp.Text = cust.Telepon;
        }

        void fillDGV()
        {
            this.customerTableAdapter.Fill(this.restoran3DataSet.Customer);

            /*
            DataGridViewColumn column = new DataGridViewColumn();
            column.Name = "Umur";
            column.HeaderText = "Umur";
            column.CellTemplate = new DataGridViewTextBoxCell();
            this.dataGridView1.Columns.Add(column);
            dataGridView1.Refresh();*/
        }

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                if (Repo.konfirmasi())
                {
                    CustomerCRUD.addCustomer(tbEmail.Text, GeneratorId.generateId("Cust"), tbNama.Text, tbTelp.Text);
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
            if (valid() && CustomerCRUD.selectedCust != null)
            {

                CustomerCRUD.selectedCust.Telepon = tbTelp.Text;
                CustomerCRUD.selectedCust.Email = tbEmail.Text;
                CustomerCRUD.selectedCust.idCustomer = tbIdCustomer.Text;
                CustomerCRUD.selectedCust.Nama = tbNama.Text;                

                if (Repo.konfirmasi())
                {
                    CustomerCRUD.updateCustomer(CustomerCRUD.selectedCust);
                    fillDGV();
                    clearField();

                }
                
            }
           

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {


            if (Repo.konfirmasi())
            {
                if (CustomerCRUD.selectedCust != null)
                {
                    CustomerCRUD.removeCustomer();
                    fillDGV();
                    clearField();
                }
                
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                CustomerCRUD.exportCustomer(this.restoran3DataSet.Customer);
            }
        }
        #endregion

        private void CustomerFragment_Load(object sender, EventArgs e)
        {
            clearField();
            fillDGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Error still
            
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //var rowIndex = e.RowIndex + 1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnAdd.Enabled = false;
                var selCust = CustomerCRUD.selectedCust = new Customer();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    selCust.Telepon = row.Cells["telepon"].Value.ToString();
                    selCust.Email = row.Cells["email"].Value.ToString();
                    selCust.Nama = row.Cells["nama"].Value.ToString();
                    selCust.idCustomer = row.Cells["idCustomer"].Value.ToString();
                }

                populate(selCust);

                CustomerCRUD.selectedCust = selCust;
            }
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Debug.Print(row.Cells[0].Value.ToString());


                var idCustomer = row.Cells[0].Value.ToString();
                Customer cust = CustomerCRUD.getByIdReturn(idCustomer);

                Debug.Print(row.Cells["Umur"].ColumnIndex.ToString());


                if (cust != null)
                {
                    row.Cells["Umur"].Value = cust.Nama;
                    //Debug.Print(cust.Nama);
                    Debug.Print("Umur Cell : " + row.Cells["Umur"].Value.ToString());
                }
            }
        }
    }
}
