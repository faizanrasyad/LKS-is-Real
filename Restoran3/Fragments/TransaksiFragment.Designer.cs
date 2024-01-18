namespace Restoran3.Fragments
{
    partial class TransaksiFragment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.transaksiTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.TransaksiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.restoran3DataSet = new Restoran3.Restoran3DataSet();
            this.customerTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.CustomerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIdUser = new System.Windows.Forms.TextBox();
            this.tbPaid = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbIdCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbidMenu = new System.Windows.Forms.TextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMeja = new System.Windows.Forms.ComboBox();
            this.menuTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.MenuTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.UserTableAdapter();
            this.itemTransaksiTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.itemTransaksiTableAdapter();
            this.btnToItemTransaksi = new System.Windows.Forms.Button();
            this.btnToMenu = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.idMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMenuItemTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.restoran3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Transaksi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // restoran3DataSet
            // 
            this.restoran3DataSet.DataSetName = "Restoran3DataSet";
            this.restoran3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMenu,
            this.jenisMenu,
            this.hargaMenu,
            this.namaMenu});
            this.dataGridView1.DataSource = this.menuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 207);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.restoran3DataSet;
            // 
            // transaksiBindingSource1
            // 
            this.transaksiBindingSource1.DataMember = "Transaksi";
            this.transaksiBindingSource1.DataSource = this.restoran3DataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(803, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 48);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(803, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 48);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "idUser";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "idCustomer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Paid";
            // 
            // tbIdUser
            // 
            this.tbIdUser.Location = new System.Drawing.Point(536, 88);
            this.tbIdUser.Name = "tbIdUser";
            this.tbIdUser.Size = new System.Drawing.Size(160, 22);
            this.tbIdUser.TabIndex = 36;
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(536, 206);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(160, 22);
            this.tbPaid.TabIndex = 37;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(536, 168);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(160, 22);
            this.tbTotal.TabIndex = 38;
            // 
            // tbIdCustomer
            // 
            this.tbIdCustomer.Location = new System.Drawing.Point(536, 128);
            this.tbIdCustomer.Name = "tbIdCustomer";
            this.tbIdCustomer.Size = new System.Drawing.Size(160, 22);
            this.tbIdCustomer.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "idMenu";
            // 
            // tbidMenu
            // 
            this.tbidMenu.Location = new System.Drawing.Point(536, 246);
            this.tbidMenu.Name = "tbidMenu";
            this.tbidMenu.Size = new System.Drawing.Size(160, 22);
            this.tbidMenu.TabIndex = 41;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(88, 88);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(150, 24);
            this.cbCustomer.TabIndex = 42;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Meja";
            // 
            // cbMeja
            // 
            this.cbMeja.FormattingEnabled = true;
            this.cbMeja.Location = new System.Drawing.Point(88, 131);
            this.cbMeja.Name = "cbMeja";
            this.cbMeja.Size = new System.Drawing.Size(150, 24);
            this.cbMeja.TabIndex = 44;
            this.cbMeja.SelectedIndexChanged += new System.EventHandler(this.cbMeja_SelectedIndexChanged);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMenuItemTransaksi,
            this.nama,
            this.harga,
            this.qty,
            this.jenis});
            this.dataGridView2.Location = new System.Drawing.Point(591, 387);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(378, 207);
            this.dataGridView2.TabIndex = 46;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // itemTransaksiBindingSource
            // 
            this.itemTransaksiBindingSource.DataMember = "itemTransaksi";
            this.itemTransaksiBindingSource.DataSource = this.restoran3DataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // itemTransaksiTableAdapter
            // 
            this.itemTransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // btnToItemTransaksi
            // 
            this.btnToItemTransaksi.Location = new System.Drawing.Point(431, 428);
            this.btnToItemTransaksi.Name = "btnToItemTransaksi";
            this.btnToItemTransaksi.Size = new System.Drawing.Size(108, 48);
            this.btnToItemTransaksi.TabIndex = 47;
            this.btnToItemTransaksi.Text = ">>>";
            this.btnToItemTransaksi.UseVisualStyleBackColor = true;
            this.btnToItemTransaksi.Click += new System.EventHandler(this.btnToItemTransaksi_Click);
            // 
            // btnToMenu
            // 
            this.btnToMenu.Location = new System.Drawing.Point(431, 505);
            this.btnToMenu.Name = "btnToMenu";
            this.btnToMenu.Size = new System.Drawing.Size(108, 48);
            this.btnToMenu.TabIndex = 48;
            this.btnToMenu.Text = "<<<";
            this.btnToMenu.UseVisualStyleBackColor = true;
            this.btnToMenu.Click += new System.EventHandler(this.btnToMenu_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(431, 387);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 49;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Quantity";
            // 
            // idMenu
            // 
            this.idMenu.DataPropertyName = "idMenu";
            this.idMenu.HeaderText = "idMenu";
            this.idMenu.MinimumWidth = 6;
            this.idMenu.Name = "idMenu";
            this.idMenu.Width = 125;
            // 
            // jenisMenu
            // 
            this.jenisMenu.DataPropertyName = "Jenis";
            this.jenisMenu.HeaderText = "Jenis";
            this.jenisMenu.MinimumWidth = 6;
            this.jenisMenu.Name = "jenisMenu";
            this.jenisMenu.Width = 125;
            // 
            // hargaMenu
            // 
            this.hargaMenu.DataPropertyName = "Harga";
            this.hargaMenu.HeaderText = "Harga";
            this.hargaMenu.MinimumWidth = 6;
            this.hargaMenu.Name = "hargaMenu";
            this.hargaMenu.Width = 125;
            // 
            // namaMenu
            // 
            this.namaMenu.DataPropertyName = "Nama";
            this.namaMenu.HeaderText = "Nama";
            this.namaMenu.MinimumWidth = 6;
            this.namaMenu.Name = "namaMenu";
            this.namaMenu.Width = 125;
            // 
            // idMenuItemTransaksi
            // 
            this.idMenuItemTransaksi.HeaderText = "idMenu";
            this.idMenuItemTransaksi.MinimumWidth = 6;
            this.idMenuItemTransaksi.Name = "idMenuItemTransaksi";
            this.idMenuItemTransaksi.Width = 125;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 125;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 125;
            // 
            // jenis
            // 
            this.jenis.HeaderText = "Jenis";
            this.jenis.MinimumWidth = 6;
            this.jenis.Name = "jenis";
            this.jenis.Width = 125;
            // 
            // TransaksiFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnToMenu);
            this.Controls.Add(this.btnToItemTransaksi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMeja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.tbidMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIdCustomer);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbPaid);
            this.Controls.Add(this.tbIdUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "TransaksiFragment";
            this.Size = new System.Drawing.Size(993, 663);
            this.Load += new System.EventHandler(this.TransaksiFragment_Load);
            this.VisibleChanged += new System.EventHandler(this.TransaksiFragment_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.restoran3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Restoran3DataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.Label label1;
        private Restoran3DataSet restoran3DataSet;
        private Restoran3DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIdUser;
        private System.Windows.Forms.TextBox tbPaid;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbIdCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbidMenu;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMeja;
        private System.Windows.Forms.BindingSource transaksiBindingSource1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private Restoran3DataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemTransaksiBindingSource;
        private Restoran3DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private Restoran3DataSetTableAdapters.itemTransaksiTableAdapter itemTransaksiTableAdapter;
        private System.Windows.Forms.Button btnToItemTransaksi;
        private System.Windows.Forms.Button btnToMenu;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuItemTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
    }
}
