namespace Restoran3
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMeja = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.transaksiFragment1 = new Restoran3.Fragments.TransaksiFragment();
            this.reportFragment1 = new Restoran3.Fragments.ReportFragment();
            this.menuFragment1 = new Restoran3.Fragments.MenuFragment();
            this.mejaFragment1 = new Restoran3.Fragments.MejaFragment();
            this.customerFragment1 = new Restoran3.Fragments.CustomerFragment();
            this.homefragment1 = new Restoran3.Fragments.Homefragment();
            this.panel1.SuspendLayout();
            this.fragmentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnMeja);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(2, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 604);
            this.panel1.TabIndex = 0;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(3, 73);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(178, 48);
            this.btnTransaksi.TabIndex = 7;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(3, 127);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(178, 48);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMeja
            // 
            this.btnMeja.Location = new System.Drawing.Point(3, 181);
            this.btnMeja.Name = "btnMeja";
            this.btnMeja.Size = new System.Drawing.Size(178, 48);
            this.btnMeja.TabIndex = 5;
            this.btnMeja.Text = "Meja";
            this.btnMeja.UseVisualStyleBackColor = true;
            this.btnMeja.Click += new System.EventHandler(this.btnMeja_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 545);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 48);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(3, 289);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(178, 48);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.Report_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(3, 235);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(178, 48);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 48);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fragmentContainer
            // 
            this.fragmentContainer.Controls.Add(this.transaksiFragment1);
            this.fragmentContainer.Controls.Add(this.reportFragment1);
            this.fragmentContainer.Controls.Add(this.menuFragment1);
            this.fragmentContainer.Controls.Add(this.mejaFragment1);
            this.fragmentContainer.Controls.Add(this.customerFragment1);
            this.fragmentContainer.Controls.Add(this.homefragment1);
            this.fragmentContainer.Location = new System.Drawing.Point(233, 2);
            this.fragmentContainer.Name = "fragmentContainer";
            this.fragmentContainer.Size = new System.Drawing.Size(993, 663);
            this.fragmentContainer.TabIndex = 2;
            // 
            // transaksiFragment1
            // 
            this.transaksiFragment1.Location = new System.Drawing.Point(3, 3);
            this.transaksiFragment1.Name = "transaksiFragment1";
            this.transaksiFragment1.Size = new System.Drawing.Size(993, 663);
            this.transaksiFragment1.TabIndex = 5;
            // 
            // reportFragment1
            // 
            this.reportFragment1.Location = new System.Drawing.Point(3, 672);
            this.reportFragment1.Name = "reportFragment1";
            this.reportFragment1.Size = new System.Drawing.Size(993, 663);
            this.reportFragment1.TabIndex = 4;
            // 
            // menuFragment1
            // 
            this.menuFragment1.Location = new System.Drawing.Point(3, 1341);
            this.menuFragment1.Name = "menuFragment1";
            this.menuFragment1.Size = new System.Drawing.Size(993, 663);
            this.menuFragment1.TabIndex = 3;
            // 
            // mejaFragment1
            // 
            this.mejaFragment1.Location = new System.Drawing.Point(3, 2010);
            this.mejaFragment1.Name = "mejaFragment1";
            this.mejaFragment1.Size = new System.Drawing.Size(993, 663);
            this.mejaFragment1.TabIndex = 2;
            // 
            // customerFragment1
            // 
            this.customerFragment1.Location = new System.Drawing.Point(3, 2679);
            this.customerFragment1.Name = "customerFragment1";
            this.customerFragment1.Size = new System.Drawing.Size(993, 663);
            this.customerFragment1.TabIndex = 1;
            // 
            // homefragment1
            // 
            this.homefragment1.Location = new System.Drawing.Point(3, 3348);
            this.homefragment1.Name = "homefragment1";
            this.homefragment1.Size = new System.Drawing.Size(993, 663);
            this.homefragment1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 666);
            this.Controls.Add(this.fragmentContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.fragmentContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fragmentContainer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnMeja;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMenu;
        private Fragments.Homefragment homefragment1;
        private Fragments.TransaksiFragment transaksiFragment1;
        private Fragments.ReportFragment reportFragment1;
        private Fragments.MenuFragment menuFragment1;
        private Fragments.MejaFragment mejaFragment1;
        private Fragments.CustomerFragment customerFragment1;
        private System.Windows.Forms.Button btnTransaksi;
    }
}