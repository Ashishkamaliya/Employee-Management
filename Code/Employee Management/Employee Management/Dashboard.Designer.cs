namespace Employee_Management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblSalaries = new System.Windows.Forms.Label();
            this.lblDepts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 53);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Employee Management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblLogout);
            this.panel2.Controls.Add(this.lblSalaries);
            this.panel2.Controls.Add(this.lblDepts);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 38);
            this.panel2.TabIndex = 41;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogout.Location = new System.Drawing.Point(987, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.lblLogout.Size = new System.Drawing.Size(88, 33);
            this.lblLogout.TabIndex = 3;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblSalaries
            // 
            this.lblSalaries.AutoSize = true;
            this.lblSalaries.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSalaries.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaries.ForeColor = System.Drawing.Color.DimGray;
            this.lblSalaries.Location = new System.Drawing.Point(250, 0);
            this.lblSalaries.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.lblSalaries.Size = new System.Drawing.Size(95, 33);
            this.lblSalaries.TabIndex = 2;
            this.lblSalaries.Text = "Salaries";
            this.lblSalaries.Click += new System.EventHandler(this.lblSalaries_Click);
            // 
            // lblDepts
            // 
            this.lblDepts.AutoSize = true;
            this.lblDepts.BackColor = System.Drawing.Color.Transparent;
            this.lblDepts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDepts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepts.ForeColor = System.Drawing.Color.DimGray;
            this.lblDepts.Location = new System.Drawing.Point(119, 0);
            this.lblDepts.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDepts.Name = "lblDepts";
            this.lblDepts.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.lblDepts.Size = new System.Drawing.Size(131, 33);
            this.lblDepts.TabIndex = 1;
            this.lblDepts.Text = "Departments";
            this.lblDepts.Click += new System.EventHandler(this.lblDepts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.label2.Size = new System.Drawing.Size(119, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employees";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.Gray;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 91);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1075, 462);
            this.ContentPanel.TabIndex = 42;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 553);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblSalaries;
        private System.Windows.Forms.Label lblDepts;
    }
}