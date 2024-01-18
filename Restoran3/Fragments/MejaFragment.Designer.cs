namespace Restoran3.Fragments
{
    partial class MejaFragment
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.tbNoMeja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.CustomerTableAdapter();
            this.restoran3DataSet = new Restoran3.Restoran3DataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noMeja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mejaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mejaTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.MejaTableAdapter();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.numKapasitas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restoran3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(702, 551);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 48);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(702, 389);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 48);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(702, 443);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 48);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(702, 497);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 48);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(702, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 48);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(276, 446);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(202, 22);
            this.tbJenis.TabIndex = 24;
            // 
            // tbNoMeja
            // 
            this.tbNoMeja.Location = new System.Drawing.Point(276, 402);
            this.tbNoMeja.Name = "tbNoMeja";
            this.tbNoMeja.Size = new System.Drawing.Size(202, 22);
            this.tbNoMeja.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kapasitas";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // restoran3DataSet
            // 
            this.restoran3DataSet.DataSetName = "Restoran3DataSet";
            this.restoran3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.restoran3DataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "noMeja";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noMeja,
            this.jenis,
            this.kapasitas,
            this.status});
            this.dataGridView1.DataSource = this.mejaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(893, 207);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // noMeja
            // 
            this.noMeja.DataPropertyName = "noMeja";
            this.noMeja.HeaderText = "noMeja";
            this.noMeja.MinimumWidth = 6;
            this.noMeja.Name = "noMeja";
            this.noMeja.Width = 125;
            // 
            // jenis
            // 
            this.jenis.DataPropertyName = "Jenis";
            this.jenis.HeaderText = "Jenis";
            this.jenis.MinimumWidth = 6;
            this.jenis.Name = "jenis";
            this.jenis.Width = 125;
            // 
            // kapasitas
            // 
            this.kapasitas.DataPropertyName = "Kapasitas";
            this.kapasitas.HeaderText = "Kapasitas";
            this.kapasitas.MinimumWidth = 6;
            this.kapasitas.Name = "kapasitas";
            this.kapasitas.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // mejaBindingSource
            // 
            this.mejaBindingSource.DataMember = "Meja";
            this.mejaBindingSource.DataSource = this.restoran3DataSet;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Meja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mejaTableAdapter
            // 
            this.mejaTableAdapter.ClearBeforeFill = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Dipakai",
            "Dibersihkan"});
            this.cbStatus.Location = new System.Drawing.Point(276, 524);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(202, 24);
            this.cbStatus.TabIndex = 30;
            // 
            // numKapasitas
            // 
            this.numKapasitas.Location = new System.Drawing.Point(276, 487);
            this.numKapasitas.Name = "numKapasitas";
            this.numKapasitas.Size = new System.Drawing.Size(202, 22);
            this.numKapasitas.TabIndex = 31;
            this.numKapasitas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(302, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "noMeja diawali \'Meja\'";
            // 
            // MejaFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numKapasitas);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbJenis);
            this.Controls.Add(this.tbNoMeja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MejaFragment";
            this.Size = new System.Drawing.Size(993, 663);
            this.Load += new System.EventHandler(this.MejaFragment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoran3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mejaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.TextBox tbNoMeja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Restoran3DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private Restoran3DataSet restoran3DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mejaBindingSource;
        private System.Windows.Forms.Label label1;
        private Restoran3DataSetTableAdapters.MejaTableAdapter mejaTableAdapter;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown numKapasitas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMeja;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
