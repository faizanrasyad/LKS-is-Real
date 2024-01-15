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
            tbKapasitas.Clear();
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
    }
}
