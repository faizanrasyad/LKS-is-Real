namespace Restoran2
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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMeja = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.fragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuFragment1 = new Restoran2.Fragments.MenuFragment();
            this.mejaFragment1 = new Restoran2.Fragments.MejaFragment();
            this.customerFragment1 = new Restoran2.Fragments.CustomerFragment();
            this.transaksiFragment1 = new Restoran2.Fragments.TransaksiFragment();
            this.homeFragment1 = new Restoran2.Fragments.HomeFragment();
            this.reportFragment1 = new Restoran2.Fragments.ReportFragment();
            this.panel1.SuspendLayout();
            this.fragmentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnMeja);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 527);
            this.panel1.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(3, 277);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(172, 45);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(3, 73);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(172, 45);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(3, 226);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(172, 45);
            this.btnTransaksi.TabIndex = 5;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(3, 175);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(172, 45);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMeja
            // 
            this.btnMeja.Location = new System.Drawing.Point(3, 124);
            this.btnMeja.Name = "btnMeja";
            this.btnMeja.Size = new System.Drawing.Size(172, 45);
            this.btnMeja.TabIndex = 3;
            this.btnMeja.Text = "Meja";
            this.btnMeja.UseVisualStyleBackColor = true;
            this.btnMeja.Click += new System.EventHandler(this.btnMeja_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 469);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 45);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // fragmentContainer
            // 
            this.fragmentContainer.Controls.Add(this.menuFragment1);
            this.fragmentContainer.Controls.Add(this.mejaFragment1);
            this.fragmentContainer.Controls.Add(this.customerFragment1);
            this.fragmentContainer.Controls.Add(this.transaksiFragment1);
            this.fragmentContainer.Controls.Add(this.homeFragment1);
            this.fragmentContainer.Controls.Add(this.reportFragment1);
            this.fragmentContainer.Location = new System.Drawing.Point(245, 0);
            this.fragmentContainer.Name = "fragmentContainer";
            this.fragmentContainer.Size = new System.Drawing.Size(844, 597);
            this.fragmentContainer.TabIndex = 6;
            // 
            // menuFragment1
            // 
            this.menuFragment1.Location = new System.Drawing.Point(3, 3);
            this.menuFragment1.Name = "menuFragment1";
            this.menuFragment1.Size = new System.Drawing.Size(844, 597);
            this.menuFragment1.TabIndex = 2;
            // 
            // mejaFragment1
            // 
            this.mejaFragment1.Location = new System.Drawing.Point(3, 606);
            this.mejaFragment1.Name = "mejaFragment1";
            this.mejaFragment1.Size = new System.Drawing.Size(844, 597);
            this.mejaFragment1.TabIndex = 1;
            // 
            // customerFragment1
            // 
            this.customerFragment1.Location = new System.Drawing.Point(3, 1209);
            this.customerFragment1.Name = "customerFragment1";
            this.customerFragment1.Size = new System.Drawing.Size(844, 597);
            this.customerFragment1.TabIndex = 0;
            // 
            // transaksiFragment1
            // 
            this.transaksiFragment1.Location = new System.Drawing.Point(3, 1812);
            this.transaksiFragment1.Name = "transaksiFragment1";
            this.transaksiFragment1.Size = new System.Drawing.Size(844, 597);
            this.transaksiFragment1.TabIndex = 4;
            // 
            // homeFragment1
            // 
            this.homeFragment1.Location = new System.Drawing.Point(3, 2415);
            this.homeFragment1.Name = "homeFragment1";
            this.homeFragment1.Size = new System.Drawing.Size(844, 597);
            this.homeFragment1.TabIndex = 5;
            // 
            // reportFragment1
            // 
            this.reportFragment1.Location = new System.Drawing.Point(3, 3018);
            this.reportFragment1.Name = "reportFragment1";
            this.reportFragment1.Size = new System.Drawing.Size(844, 597);
            this.reportFragment1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 596);
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
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMeja;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel fragmentContainer;
        private Fragments.MenuFragment menuFragment1;
        private Fragments.MejaFragment mejaFragment1;
        private Fragments.CustomerFragment customerFragment1;
        private Fragments.TransaksiFragment transaksiFragment1;
        private Fragments.HomeFragment homeFragment1;
        private Fragments.ReportFragment reportFragment1;
    }
}