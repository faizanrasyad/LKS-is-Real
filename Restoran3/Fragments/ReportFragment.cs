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

namespace Restoran3.Fragments
{
    public partial class ReportFragment : UserControl
    {
        public ReportFragment()
        {
            InitializeComponent();
        }

        void clearField()
        {
            tbIdReport.Clear();
            tbIdTransaksi.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value  = DateTime.Now;
        }

        bool valid()
        {
            if (String.IsNullOrEmpty(tbIdReport.Text))
            {
                MessageBox.Show("idReport tidak boleh kosong");
                return false;
            }

            if (String.IsNullOrEmpty(tbIdTransaksi.Text))
            {
                MessageBox.Show("idTransaksi tidak boleh kosong");
                return false;
            }

            if (!tbIdReport.Text.StartsWith("Report"))
            {
                MessageBox.Show("idCustomer tidak valid");
                return false;
            }

            return true;
        }

        void populate(Report report)
        {
            tbIdReport.Text = report.idReport;
            tbIdTransaksi.Text = report.idTransaksi;
            dateTimePicker1.Value = report.rangeStart;
            dateTimePicker2.Value = report.rangeEnd;
        }

        void fillDGV()
        {
            this.reportTableAdapter.Fill(this.restoran3DataSet.Report);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        #region buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Repo.konfirmasi())
            {
                //todo
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

        private void ReportFragment_Load(object sender, EventArgs e)
        {
            clearField();
            fillDGV();
        }
    }
}
