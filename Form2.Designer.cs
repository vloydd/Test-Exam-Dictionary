namespace Ukrainian_English_Dictionary
{
    partial class Config
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
            this.nameLbUa = new System.Windows.Forms.Label();
            this.nameLbEn = new System.Windows.Forms.Label();
            this.lbUa = new System.Windows.Forms.ListBox();
            this.lbEn = new System.Windows.Forms.ListBox();
            this.inpEn = new System.Windows.Forms.TextBox();
            this.inpUa = new System.Windows.Forms.TextBox();
            this.closeAdminButton = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbUa
            // 
            this.nameLbUa.AutoSize = true;
            this.nameLbUa.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbUa.Location = new System.Drawing.Point(179, 51);
            this.nameLbUa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbUa.Name = "nameLbUa";
            this.nameLbUa.Size = new System.Drawing.Size(95, 27);
            this.nameLbUa.TabIndex = 0;
            this.nameLbUa.Text = "Ukrainian";
            this.nameLbUa.Click += new System.EventHandler(this.nameLbUa_Click);
            // 
            // nameLbEn
            // 
            this.nameLbEn.AutoSize = true;
            this.nameLbEn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbEn.Location = new System.Drawing.Point(179, 259);
            this.nameLbEn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbEn.Name = "nameLbEn";
            this.nameLbEn.Size = new System.Drawing.Size(82, 29);
            this.nameLbEn.TabIndex = 1;
            this.nameLbEn.Text = "English";
            this.nameLbEn.Click += new System.EventHandler(this.nameLbEn_Click);
            // 
            // lbUa
            // 
            this.lbUa.FormattingEnabled = true;
            this.lbUa.ItemHeight = 16;
            this.lbUa.Location = new System.Drawing.Point(44, 114);
            this.lbUa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbUa.Name = "lbUa";
            this.lbUa.Size = new System.Drawing.Size(346, 116);
            this.lbUa.TabIndex = 2;
            // 
            // lbEn
            // 
            this.lbEn.FormattingEnabled = true;
            this.lbEn.ItemHeight = 16;
            this.lbEn.Location = new System.Drawing.Point(44, 324);
            this.lbEn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbEn.Name = "lbEn";
            this.lbEn.Size = new System.Drawing.Size(346, 116);
            this.lbEn.TabIndex = 3;
            // 
            // inpEn
            // 
            this.inpEn.Location = new System.Drawing.Point(44, 292);
            this.inpEn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inpEn.Name = "inpEn";
            this.inpEn.Size = new System.Drawing.Size(346, 23);
            this.inpEn.TabIndex = 4;
            this.inpEn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inpEn_KeyUp);
            // 
            // inpUa
            // 
            this.inpUa.Location = new System.Drawing.Point(44, 82);
            this.inpUa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inpUa.Name = "inpUa";
            this.inpUa.Size = new System.Drawing.Size(346, 23);
            this.inpUa.TabIndex = 5;
            this.inpUa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inpUa_KeyUp);
            // 
            // closeAdminButton
            // 
            this.closeAdminButton.BackColor = System.Drawing.Color.Silver;
            this.closeAdminButton.ForeColor = System.Drawing.Color.IndianRed;
            this.closeAdminButton.Location = new System.Drawing.Point(262, 487);
            this.closeAdminButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeAdminButton.Name = "closeAdminButton";
            this.closeAdminButton.Size = new System.Drawing.Size(128, 28);
            this.closeAdminButton.TabIndex = 6;
            this.closeAdminButton.Text = "Close Configuration";
            this.closeAdminButton.UseVisualStyleBackColor = false;
            this.closeAdminButton.Click += new System.EventHandler(this.closeAdminButton_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEdit.Location = new System.Drawing.Point(44, 487);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 28);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 530);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.closeAdminButton);
            this.Controls.Add(this.inpUa);
            this.Controls.Add(this.inpEn);
            this.Controls.Add(this.lbEn);
            this.Controls.Add(this.lbUa);
            this.Controls.Add(this.nameLbEn);
            this.Controls.Add(this.nameLbUa);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Config";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbUa;
        private System.Windows.Forms.Label nameLbEn;
        public System.Windows.Forms.ListBox lbUa;
        public System.Windows.Forms.ListBox lbEn;
        private System.Windows.Forms.TextBox inpEn;
        private System.Windows.Forms.TextBox inpUa;
        private System.Windows.Forms.Button closeAdminButton;
        private System.Windows.Forms.Button btnEdit;
    }
}