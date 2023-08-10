namespace TestingPhase
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisitor = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(147)))), ((int)(((byte)(151)))));
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmployees,
            this.btnUser,
            this.btnVisitor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1442, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEmployees
            // 
            this.btnEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewEmployee,
            this.btnAddEmployee,
            this.btnUpdate,
            this.btnDelete});
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(142, 36);
            this.btnEmployees.Text = "Employees";
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnViewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnViewEmployee.Image")));
            this.btnViewEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.Size = new System.Drawing.Size(238, 38);
            this.btnViewEmployee.Text = "View Employee";
            this.btnViewEmployee.Click += new System.EventHandler(this.btnViewEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(238, 38);
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(238, 38);
            this.btnUpdate.Text = "Update Employee";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(238, 38);
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUser
            // 
            this.btnUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout});
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(44, 36);
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 38);
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnVisitor
            // 
            this.btnVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnVisitor.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitor.Image")));
            this.btnVisitor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(166, 36);
            this.btnVisitor.Text = "Visitor\'s Form";
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(800, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(344, 58);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Dashboard";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1442, 1019);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEmployees;
        private System.Windows.Forms.ToolStripMenuItem btnViewEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnUser;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem btnVisitor;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
    }
}