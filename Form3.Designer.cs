namespace Ukrainian_English_Dictionary
{
    partial class Edit
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
            this.tbSearchEdit = new System.Windows.Forms.TextBox();
            this.tbEditWord = new System.Windows.Forms.TextBox();
            this.btnCloseEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSearchEdit
            // 
            this.tbSearchEdit.Location = new System.Drawing.Point(12, 110);
            this.tbSearchEdit.Name = "tbSearchEdit";
            this.tbSearchEdit.Size = new System.Drawing.Size(410, 20);
            this.tbSearchEdit.TabIndex = 0;
            // 
            // tbEditWord
            // 
            this.tbEditWord.Location = new System.Drawing.Point(12, 148);
            this.tbEditWord.Name = "tbEditWord";
            this.tbEditWord.Size = new System.Drawing.Size(410, 20);
            this.tbEditWord.TabIndex = 1;
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.BackColor = System.Drawing.Color.Silver;
            this.btnCloseEdit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCloseEdit.Location = new System.Drawing.Point(305, 440);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(117, 31);
            this.btnCloseEdit.TabIndex = 2;
            this.btnCloseEdit.Text = "Close";
            this.btnCloseEdit.UseVisualStyleBackColor = false;
            this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 483);
            this.Controls.Add(this.btnCloseEdit);
            this.Controls.Add(this.tbEditWord);
            this.Controls.Add(this.tbSearchEdit);
            this.Name = "Edit";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchEdit;
        private System.Windows.Forms.TextBox tbEditWord;
        private System.Windows.Forms.Button btnCloseEdit;
    }
}