namespace Restoran3.Fragments
{
    partial class ReportFragment
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
            this.tbIdTransaksi = new System.Windows.Forms.TextBox();
            this.tbIdReport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.CustomerTableAdapter();
            this.restoran3DataSet = new Restoran3.Restoran3DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idReportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reportTableAdapter = new Restoran3.Restoran3DataSetTableAdapters.ReportTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.restoran3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(701, 554);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 48);
            this.btnExport.TabIndex = 29;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(701, 392);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 48);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(701, 446);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 48);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(701, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 48);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(701, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 48);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbIdTransaksi
            // 
            this.tbIdTransaksi.Location = new System.Drawing.Point(275, 527);
            this.tbIdTransaksi.Name = "tbIdTransaksi";
            this.tbIdTransaksi.Size = new System.Drawing.Size(202, 22);
            this.tbIdTransaksi.TabIndex = 22;
            // 
            // tbIdReport
            // 
            this.tbIdReport.Location = new System.Drawing.Point(275, 405);
            this.tbIdReport.Name = "tbIdReport";
            this.tbIdReport.Size = new System.Drawing.Size(202, 22);
            this.tbIdReport.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "idTransaksi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Range Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Range End";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "idReport";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReportDataGridViewTextBoxColumn,
            this.rangeStartDataGridViewTextBoxColumn,
            this.rangeEndDataGridViewTextBoxColumn,
            this.idTransaksiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(893, 207);
            this.dataGridView1.TabIndex = 16;
            // 
            // idReportDataGridViewTextBoxColumn
            // 
            this.idReportDataGridViewTextBoxColumn.DataPropertyName = "idReport";
            this.idReportDataGridViewTextBoxColumn.HeaderText = "idReport";
            this.idReportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idReportDataGridViewTextBoxColumn.Name = "idReportDataGridViewTextBoxColumn";
            this.idReportDataGridViewTextBoxColumn.Width = 125;
            // 
            // rangeStartDataGridViewTextBoxColumn
            // 
            this.rangeStartDataGridViewTextBoxColumn.DataPropertyName = "rangeStart";
            this.rangeStartDataGridViewTextBoxColumn.HeaderText = "rangeStart";
            this.rangeStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rangeStartDataGridViewTextBoxColumn.Name = "rangeStartDataGridViewTextBoxColumn";
            this.rangeStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // rangeEndDataGridViewTextBoxColumn
            // 
            this.rangeEndDataGridViewTextBoxColumn.DataPropertyName = "rangeEnd";
            this.rangeEndDataGridViewTextBoxColumn.HeaderText = "rangeEnd";
            this.rangeEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rangeEndDataGridViewTextBoxColumn.Name = "rangeEndDataGridViewTextBoxColumn";
            this.rangeEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTransaksiDataGridViewTextBoxColumn
            // 
            this.idTransaksiDataGridViewTextBoxColumn.DataPropertyName = "idTransaksi";
            this.idTransaksiDataGridViewTextBoxColumn.HeaderText = "idTransaksi";
            this.idTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTransaksiDataGridViewTextBoxColumn.Name = "idTransaksiDataGridViewTextBoxColumn";
            this.idTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.restoran3DataSet;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 447);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(275, 487);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(223, 22);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // ReportFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbIdTransaksi);
            this.Controls.Add(this.tbIdReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ReportFragment";
            this.Size = new System.Drawing.Size(993, 663);
            this.Load += new System.EventHandler(this.ReportFragment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoran3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbIdTransaksi;
        private System.Windows.Forms.TextBox tbIdReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Restoran3DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private Restoran3DataSet restoran3DataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.Label label1;
        private Restoran3DataSetTableAdapters.ReportTableAdapter reportTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
