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
    public partial class CustomerFragment : UserControl
    {
        public CustomerFragment()
        {
            InitializeComponent();
        }

        void clearField()
        {
            tbNama.Clear();
            tbEmail.Clear();
            tbIdCustomer.Clear();
            tbTelepon.Clear();
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return false;
            }
            else if (String.IsNullOrEmpty(tbIdCustomer.Text))
            {
                MessageBox.Show("idCustomer tidak boleh kosong");    
                return false;
            }else if (String.IsNullOrEmpty(tbNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong");
                return false;
            }else if (String.IsNullOrEmpty(tbTelepon.Text))
            {
                MessageBox.Show("Telepon tidak boleh kosong");
                return false;
            }else if (!tbEmail.Text.EndsWith("@gmail.com") || !tbEmail.Text.EndsWith("@yahoo.com"))
            {
                MessageBox.Show("Email tidak valid");
                return false;
            }else if(tbTelepon.Text.Length < 10 || !tbTelepon.Text.StartsWith("08"))
            {
                MessageBox.Show("Telepon tidak valid");
                return false;
            }else if (!tbIdCustomer.Text.StartsWith("Cust"))
            {
                MessageBox.Show("idCustomer tidak valid");
                return false;
            }
            else
            {
                return true;
            }
        }

        void fillDGV()
        {
            this.customerTableAdapter.Fill(this.restoran2DataSet.Customer);
        }

        void masukin()
        {
            Restoran2Entities enti = new Restoran2Entities();
            var cust = new Customer()
            {
                email = tbEmail.Text,
                idCustomer = tbIdCustomer.Text,
                nama = tbNama.Text,
                telp = tbTelepon.Text,

            };
            enti.Customers.Add(cust);
            var confirm = Repo.konfirmasi();
            if (confirm == true)
            {
                enti.SaveChanges();
                fillDGV();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                masukin();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerFragment_Load(object sender, EventArgs e)
        {
            fillDGV() ;
        }
    }
}
