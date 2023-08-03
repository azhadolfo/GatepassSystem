namespace TestingPhase
{
    partial class msgOK
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(219, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 34);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(122, 83);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(310, 45);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Successfully Completed";
            // 
            // msgOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(560, 275);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOK);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "msgOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgOK";
            this.Load += new System.EventHandler(this.msgOK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMessage;
    }
}