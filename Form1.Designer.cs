namespace Ukrainian_English_Dictionary
{
    partial class Dictionary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminButton = new System.Windows.Forms.Button();
            this.rb_ua = new System.Windows.Forms.RadioButton();
            this.rb_en = new System.Windows.Forms.RadioButton();
            this.lbTranslate1 = new System.Windows.Forms.Label();
            this.lbTranslate2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearchRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.Silver;
            this.adminButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminButton.ForeColor = System.Drawing.Color.IndianRed;
            this.adminButton.Location = new System.Drawing.Point(12, 12);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(360, 39);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Configure Translation";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // rb_ua
            // 
            this.rb_ua.AutoSize = true;
            this.rb_ua.Location = new System.Drawing.Point(12, 72);
            this.rb_ua.Name = "rb_ua";
            this.rb_ua.Size = new System.Drawing.Size(115, 20);
            this.rb_ua.TabIndex = 1;
            this.rb_ua.TabStop = true;
            this.rb_ua.Text = "Ukrainian-English";
            this.rb_ua.UseVisualStyleBackColor = true;
            this.rb_ua.CheckedChanged += new System.EventHandler(this.rb_ua_CheckedChanged);
            // 
            // rb_en
            // 
            this.rb_en.AutoSize = true;
            this.rb_en.Location = new System.Drawing.Point(257, 72);
            this.rb_en.Name = "rb_en";
            this.rb_en.Size = new System.Drawing.Size(115, 20);
            this.rb_en.TabIndex = 2;
            this.rb_en.TabStop = true;
            this.rb_en.Text = "English-Ukrainian";
            this.rb_en.UseVisualStyleBackColor = true;
            this.rb_en.CheckedChanged += new System.EventHandler(this.rb_en_CheckedChanged);
            // 
            // lbTranslate1
            // 
            this.lbTranslate1.AutoSize = true;
            this.lbTranslate1.Location = new System.Drawing.Point(63, 158);
            this.lbTranslate1.Name = "lbTranslate1";
            this.lbTranslate1.Size = new System.Drawing.Size(64, 16);
            this.lbTranslate1.TabIndex = 3;
            this.lbTranslate1.Text = "Translate 1";
            this.lbTranslate1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTranslate2
            // 
            this.lbTranslate2.AutoSize = true;
            this.lbTranslate2.Location = new System.Drawing.Point(254, 158);
            this.lbTranslate2.Name = "lbTranslate2";
            this.lbTranslate2.Size = new System.Drawing.Size(69, 16);
            this.lbTranslate2.TabIndex = 4;
            this.lbTranslate2.Text = "Translate 2 ";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 240);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(131, 23);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.Text = "Search";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // lbSearchRes
            // 
            this.lbSearchRes.AutoSize = true;
            this.lbSearchRes.Location = new System.Drawing.Point(239, 247);
            this.lbSearchRes.Name = "lbSearchRes";
            this.lbSearchRes.Size = new System.Drawing.Size(84, 16);
            this.lbSearchRes.TabIndex = 6;
            this.lbSearchRes.Text = "Search Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(161, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(103, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Added Word";
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSearchRes);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbTranslate2);
            this.Controls.Add(this.lbTranslate1);
            this.Controls.Add(this.rb_en);
            this.Controls.Add(this.rb_ua);
            this.Controls.Add(this.adminButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dictionary";
            this.Text = "Ukrainian-English Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        public System.Windows.Forms.RadioButton rb_ua;
        public System.Windows.Forms.RadioButton rb_en;
        private System.Windows.Forms.Label lbTranslate1;
        private System.Windows.Forms.Label lbTranslate2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearchRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

