namespace Restoran1
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKustomer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.fragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 447);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 49);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKustomer);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 508);
            this.panel1.TabIndex = 2;
            // 
            // btnKustomer
            // 
            this.btnKustomer.Location = new System.Drawing.Point(0, 58);
            this.btnKustomer.Name = "btnKustomer";
            this.btnKustomer.Size = new System.Drawing.Size(186, 49);
            this.btnKustomer.TabIndex = 2;
            this.btnKustomer.Text = "Kustomer";
            this.btnKustomer.UseVisualStyleBackColor = true;
            this.btnKustomer.Click += new System.EventHandler(this.btnKustomer_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 49);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fragmentContainer
            // 
            this.fragmentContainer.Location = new System.Drawing.Point(215, 0);
            this.fragmentContainer.Name = "fragmentContainer";
            this.fragmentContainer.Size = new System.Drawing.Size(936, 597);
            this.fragmentContainer.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 597);
            this.Controls.Add(this.fragmentContainer);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.FlowLayoutPanel fragmentContainer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnKustomer;
    }
}