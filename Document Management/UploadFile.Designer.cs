namespace TestingPhase.Document_Management
{
    partial class UploadFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadFile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.btnUpload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 33);
            this.label6.TabIndex = 43;
            this.label6.Text = "Description";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.txtFileName.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.txtFileName.Location = new System.Drawing.Point(136, 13);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(389, 36);
            this.txtFileName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 33);
            this.label3.TabIndex = 36;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "File Name";
            // 
            // cboDepartment
            // 
            this.cboDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDepartment.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "Accounting",
            "Credits",
            "Finance",
            "HR/Admin",
            "MIS",
            "Marketing",
            "Operation",
            "Retail",
            "Logistic"});
            this.cboDepartment.Location = new System.Drawing.Point(136, 86);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(436, 37);
            this.cboDepartment.TabIndex = 46;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.txtDescription.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.txtDescription.Location = new System.Drawing.Point(136, 160);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(435, 143);
            this.txtDescription.TabIndex = 47;
            this.txtDescription.Text = "";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.FlatAppearance.BorderSize = 0;
            this.btnSearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFile.Image = global::TestingPhase.Properties.Resources.search__1_;
            this.btnSearchFile.Location = new System.Drawing.Point(531, 14);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(40, 35);
            this.btnSearchFile.TabIndex = 45;
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AllowAnimations = true;
            this.btnUpload.AllowMouseEffects = true;
            this.btnUpload.AllowToggling = false;
            this.btnUpload.AnimationSpeed = 200;
            this.btnUpload.AutoGenerateColors = false;
            this.btnUpload.AutoRoundBorders = false;
            this.btnUpload.AutoSizeLeftIcon = true;
            this.btnUpload.AutoSizeRightIcon = true;
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.btnUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpload.BackgroundImage")));
            this.btnUpload.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpload.ButtonText = "";
            this.btnUpload.ButtonTextMarginLeft = 0;
            this.btnUpload.ColorContrastOnClick = 45;
            this.btnUpload.ColorContrastOnHover = 45;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnUpload.CustomizableEdges = borderEdges1;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpload.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpload.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpload.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpload.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpload.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUpload.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUpload.IconMarginLeft = 11;
            this.btnUpload.IconPadding = 10;
            this.btnUpload.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpload.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUpload.IconSize = 25;
            this.btnUpload.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUpload.IdleBorderRadius = 20;
            this.btnUpload.IdleBorderThickness = 1;
            this.btnUpload.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.btnUpload.IdleIconLeftImage = null;
            this.btnUpload.IdleIconRightImage = global::TestingPhase.Properties.Resources.up_loading;
            this.btnUpload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpload.IndicateFocus = false;
            this.btnUpload.Location = new System.Drawing.Point(440, 353);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUpload.OnDisabledState.BorderRadius = 20;
            this.btnUpload.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpload.OnDisabledState.BorderThickness = 1;
            this.btnUpload.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpload.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpload.OnDisabledState.IconLeftImage = null;
            this.btnUpload.OnDisabledState.IconRightImage = null;
            this.btnUpload.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUpload.onHoverState.BorderRadius = 20;
            this.btnUpload.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpload.onHoverState.BorderThickness = 1;
            this.btnUpload.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.btnUpload.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpload.onHoverState.IconLeftImage = null;
            this.btnUpload.onHoverState.IconRightImage = null;
            this.btnUpload.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUpload.OnIdleState.BorderRadius = 20;
            this.btnUpload.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpload.OnIdleState.BorderThickness = 1;
            this.btnUpload.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.btnUpload.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUpload.OnIdleState.IconLeftImage = null;
            this.btnUpload.OnIdleState.IconRightImage = global::TestingPhase.Properties.Resources.up_loading;
            this.btnUpload.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnUpload.OnPressedState.BorderRadius = 20;
            this.btnUpload.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpload.OnPressedState.BorderThickness = 1;
            this.btnUpload.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.btnUpload.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUpload.OnPressedState.IconLeftImage = null;
            this.btnUpload.OnPressedState.IconRightImage = null;
            this.btnUpload.Size = new System.Drawing.Size(131, 47);
            this.btnUpload.TabIndex = 48;
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpload.TextMarginLeft = 0;
            this.btnUpload.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUpload.UseDefaultRadiusAndThickness = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.btnSearchFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UploadFile";
            this.Size = new System.Drawing.Size(589, 638);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpload;
    }
}
