namespace Restoran2.Fragments
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
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoran2DataSet = new Restoran2.Restoran2DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new Restoran2.Restoran2DataSetTableAdapters.TransaksiTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbStatusTr = new System.Windows.Forms.TextBox();
            this.tbMenu = new System.Windows.Forms.TextBox();
            this.menuTableAdapter = new Restoran2.Restoran2DataSetTableAdapters.MenuTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdTransaksi = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new Restoran2.Restoran2DataSetTableAdapters.CustomerTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.mejaTableAdapter = new Restoran2.Restoran2DataSetTableAdapters.MejaTableAdapter();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPembayaran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStatusPb = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbTerbayar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoran2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.restoran2DataSet;
            // 
            // restoran2DataSet
            // 
            this.restoran2DataSet.DataSetName = "Restoran2DataSet";
            this.restoran2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "idTransaksi";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "Transaksi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransaksiDataGridViewTextBoxColumn,
            this.tanggalTransaksiDataGridViewTextBoxColumn,
            this.idMenuDataGridViewTextBoxColumn,
            this.statusTransaksiDataGridViewTextBoxColumn,
            this.pembayaranDataGridViewTextBoxColumn,
            this.statusPembayaranDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 203);
            this.dataGridView1.TabIndex = 42;
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "Menu";
            this.menuBindingSource1.DataSource = this.restoran2DataSet;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 43);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(684, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 43);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(684, 379);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 43);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tbStatusTr
            // 
            this.tbStatusTr.Location = new System.Drawing.Point(129, 483);
            this.tbStatusTr.Name = "tbStatusTr";
            this.tbStatusTr.Size = new System.Drawing.Size(189, 22);
            this.tbStatusTr.TabIndex = 51;
            // 
            // tbMenu
            // 
            this.tbMenu.Location = new System.Drawing.Point(129, 438);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(189, 22);
            this.tbMenu.TabIndex = 50;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(684, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 43);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Status Tr.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Menu";
            // 
            // tbIdTransaksi
            // 
            this.tbIdTransaksi.Location = new System.Drawing.Point(129, 354);
            this.tbIdTransaksi.Name = "tbIdTransaksi";
            this.tbIdTransaksi.Size = new System.Drawing.Size(189, 22);
            this.tbIdTransaksi.TabIndex = 46;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tanggal";
            // 
            // mejaTableAdapter
            // 
            this.mejaTableAdapter.ClearBeforeFill = true;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.restoran2DataSet;
            // 
            // idTransaksiDataGridViewTextBoxColumn
            // 
            this.idTransaksiDataGridViewTextBoxColumn.DataPropertyName = "idTransaksi";
            this.idTransaksiDataGridViewTextBoxColumn.HeaderText = "idTransaksi";
            this.idTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTransaksiDataGridViewTextBoxColumn.Name = "idTransaksiDataGridViewTextBoxColumn";
            this.idTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalTransaksiDataGridViewTextBoxColumn
            // 
            this.tanggalTransaksiDataGridViewTextBoxColumn.DataPropertyName = "tanggalTransaksi";
            this.tanggalTransaksiDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalTransaksiDataGridViewTextBoxColumn.Name = "tanggalTransaksiDataGridViewTextBoxColumn";
            this.tanggalTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMenuDataGridViewTextBoxColumn
            // 
            this.idMenuDataGridViewTextBoxColumn.DataPropertyName = "idMenu";
            this.idMenuDataGridViewTextBoxColumn.HeaderText = "Menu";
            this.idMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMenuDataGridViewTextBoxColumn.Name = "idMenuDataGridViewTextBoxColumn";
            this.idMenuDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusTransaksiDataGridViewTextBoxColumn
            // 
            this.statusTransaksiDataGridViewTextBoxColumn.DataPropertyName = "statusTransaksi";
            this.statusTransaksiDataGridViewTextBoxColumn.HeaderText = "Status Transaksi";
            this.statusTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusTransaksiDataGridViewTextBoxColumn.Name = "statusTransaksiDataGridViewTextBoxColumn";
            this.statusTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // pembayaranDataGridViewTextBoxColumn
            // 
            this.pembayaranDataGridViewTextBoxColumn.DataPropertyName = "pembayaran";
            this.pembayaranDataGridViewTextBoxColumn.HeaderText = "Pembayaran";
            this.pembayaranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pembayaranDataGridViewTextBoxColumn.Name = "pembayaranDataGridViewTextBoxColumn";
            this.pembayaranDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPembayaranDataGridViewTextBoxColumn
            // 
            this.statusPembayaranDataGridViewTextBoxColumn.DataPropertyName = "statusPembayaran";
            this.statusPembayaranDataGridViewTextBoxColumn.HeaderText = "Status Pembayaran";
            this.statusPembayaranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusPembayaranDataGridViewTextBoxColumn.Name = "statusPembayaranDataGridViewTextBoxColumn";
            this.statusPembayaranDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Terbayar";
            this.paidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Status Pb.";
            // 
            // tbPembayaran
            // 
            this.tbPembayaran.Location = new System.Drawing.Point(449, 351);
            this.tbPembayaran.Name = "tbPembayaran";
            this.tbPembayaran.Size = new System.Drawing.Size(189, 22);
            this.tbPembayaran.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Terbayar";
            // 
            // tbStatusPb
            // 
            this.tbStatusPb.Location = new System.Drawing.Point(449, 395);
            this.tbStatusPb.Name = "tbStatusPb";
            this.tbStatusPb.Size = new System.Drawing.Size(189, 22);
            this.tbStatusPb.TabIndex = 61;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(449, 438);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(189, 22);
            this.tbTotal.TabIndex = 62;
            // 
            // tbTerbayar
            // 
            this.tbTerbayar.Location = new System.Drawing.Point(449, 483);
            this.tbTerbayar.Name = "tbTerbayar";
            this.tbTerbayar.Size = new System.Drawing.Size(189, 22);
            this.tbTerbayar.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Pembayaran";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(129, 395);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker.TabIndex = 64;
            // 
            // TransaksiFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTerbayar);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbStatusPb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPembayaran);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbStatusTr);
            this.Controls.Add(this.tbMenu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIdTransaksi);
            this.Controls.Add(this.label3);
            this.Name = "TransaksiFragment";
            this.Size = new System.Drawing.Size(844, 597);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoran2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource menuBindingSource;
        private Restoran2DataSet restoran2DataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private Restoran2DataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbStatusTr;
        private System.Windows.Forms.TextBox tbMenu;
        private Restoran2DataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdTransaksi;
        private Restoran2DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label label3;
        private Restoran2DataSetTableAdapters.MejaTableAdapter mejaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPembayaran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStatusPb;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbTerbayar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
