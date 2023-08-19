namespace TestingPhase.Main_Form
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDms = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGatepass = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.panel1);
            this.bunifuPanel1.Controls.Add(this.panelMenu);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1106, 692);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 60);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDms,
            this.btnUser,
            this.btnGatepass,
            this.btnEmployees,
            this.btnLogs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnDms
            // 
            this.btnDms.Checked = true;
            this.btnDms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnDms.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnDms.Image = global::TestingPhase.Properties.Resources.folder;
            this.btnDms.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDms.Name = "btnDms";
            this.btnDms.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.btnDms.Size = new System.Drawing.Size(224, 56);
            this.btnDms.Text = "Document Management";
            this.btnDms.Click += new System.EventHandler(this.btnDms_Click);
            // 
            // btnUser
            // 
            this.btnUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout});
            this.btnUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUser.Image = global::TestingPhase.Properties.Resources.profile_user1;
            this.btnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.btnUser.Size = new System.Drawing.Size(105, 56);
            this.btnUser.Text = "Admin";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(196, 38);
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGatepass
            // 
            this.btnGatepass.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGatepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnGatepass.Image = global::TestingPhase.Properties.Resources.pass__1_;
            this.btnGatepass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGatepass.Name = "btnGatepass";
            this.btnGatepass.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.btnGatepass.Size = new System.Drawing.Size(124, 56);
            this.btnGatepass.Text = "Gatepass";
            this.btnGatepass.Click += new System.EventHandler(this.btnGatepass_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnView,
            this.btnAdd,
            this.btnUpdate,
            this.btnDelete});
            this.btnEmployees.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnEmployees.Image = global::TestingPhase.Properties.Resources.multiple_users_silhouette1;
            this.btnEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.btnEmployees.Size = new System.Drawing.Size(99, 56);
            this.btnEmployees.Text = "Users";
            // 
            // btnView
            // 
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(196, 38);
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 38);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 38);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 38);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnLogs.Image = global::TestingPhase.Properties.Resources.file__1_;
            this.btnLogs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Padding = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.btnLogs.Size = new System.Drawing.Size(91, 56);
            this.btnLogs.Text = "Logs";
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(147)))), ((int)(((byte)(151)))));
            this.panelMenu.Controls.Add(this.btnDownloadFile);
            this.panelMenu.Controls.Add(this.btnUploadFile);
            this.panelMenu.Controls.Add(this.btnVisitor);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 692);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDownloadFile.FlatAppearance.BorderSize = 0;
            this.btnDownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadFile.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnDownloadFile.Image = global::TestingPhase.Properties.Resources.approved;
            this.btnDownloadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadFile.Location = new System.Drawing.Point(0, 180);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDownloadFile.Size = new System.Drawing.Size(220, 60);
            this.btnDownloadFile.TabIndex = 7;
            this.btnDownloadFile.Text = "Download File";
            this.btnDownloadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadFile.UseVisualStyleBackColor = true;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUploadFile.FlatAppearance.BorderSize = 0;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFile.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUploadFile.Image = global::TestingPhase.Properties.Resources.approved;
            this.btnUploadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadFile.Location = new System.Drawing.Point(0, 120);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnUploadFile.Size = new System.Drawing.Size(220, 60);
            this.btnUploadFile.TabIndex = 6;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadFile.UseVisualStyleBackColor = true;
            // 
            // btnVisitor
            // 
            this.btnVisitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitor.FlatAppearance.BorderSize = 0;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnVisitor.Image = global::TestingPhase.Properties.Resources.approved;
            this.btnVisitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.Location = new System.Drawing.Point(0, 60);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnVisitor.Size = new System.Drawing.Size(220, 60);
            this.btnVisitor.TabIndex = 5;
            this.btnVisitor.Text = "Visitor\'s Form";
            this.btnVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisitor.UseVisualStyleBackColor = true;
            this.btnVisitor.Visible = false;
            this.btnVisitor.Click += new System.EventHandler(this.btnVisitor_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.panelLogo.Controls.Add(this.bunifuLabel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(81, 27);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(32, 15);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "LOGO";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1106, 692);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDms;
        private System.Windows.Forms.ToolStripMenuItem btnUser;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnGatepass;
        private System.Windows.Forms.ToolStripMenuItem btnLogs;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.ToolStripMenuItem btnEmployees;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
    }
}