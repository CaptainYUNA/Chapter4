namespace Chapter4
{
    partial class Form2
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
            this.GDPListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wellCityListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HappyCityListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GDPListBox
            // 
            this.GDPListBox.FormattingEnabled = true;
            this.GDPListBox.ItemHeight = 12;
            this.GDPListBox.Location = new System.Drawing.Point(27, 44);
            this.GDPListBox.Name = "GDPListBox";
            this.GDPListBox.Size = new System.Drawing.Size(134, 208);
            this.GDPListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "GDP 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "살기 좋은 도시";
            // 
            // wellCityListBox
            // 
            this.wellCityListBox.FormattingEnabled = true;
            this.wellCityListBox.ItemHeight = 12;
            this.wellCityListBox.Location = new System.Drawing.Point(190, 44);
            this.wellCityListBox.Name = "wellCityListBox";
            this.wellCityListBox.Size = new System.Drawing.Size(134, 208);
            this.wellCityListBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "행복한 나라";
            // 
            // HappyCityListBox
            // 
            this.HappyCityListBox.FormattingEnabled = true;
            this.HappyCityListBox.ItemHeight = 12;
            this.HappyCityListBox.Location = new System.Drawing.Point(352, 44);
            this.HappyCityListBox.Name = "HappyCityListBox";
            this.HappyCityListBox.Size = new System.Drawing.Size(134, 208);
            this.HappyCityListBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selected Item Index:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selected Item Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HappyCityListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wellCityListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GDPListBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chapter 140 ~ 144";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GDPListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox wellCityListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox HappyCityListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}