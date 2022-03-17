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
            this.gdpIndex = new System.Windows.Forms.TextBox();
            this.gdpCityName = new System.Windows.Forms.TextBox();
            this.wellName = new System.Windows.Forms.TextBox();
            this.wellIndex = new System.Windows.Forms.TextBox();
            this.favoriteRestaurant = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.restaurantComboBox = new System.Windows.Forms.ComboBox();
            this.restaurantList = new System.Windows.Forms.Label();
            this.groupBox142 = new System.Windows.Forms.GroupBox();
            this.checkedItems = new System.Windows.Forms.ListBox();
            this.allMoveRight = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.favoriteRestaurant.SuspendLayout();
            this.groupBox142.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GDPListBox
            // 
            this.GDPListBox.FormattingEnabled = true;
            this.GDPListBox.ItemHeight = 12;
            this.GDPListBox.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "영국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "한국",
            "호주"});
            this.GDPListBox.Location = new System.Drawing.Point(27, 44);
            this.GDPListBox.Name = "GDPListBox";
            this.GDPListBox.Size = new System.Drawing.Size(134, 208);
            this.GDPListBox.TabIndex = 0;
            this.GDPListBox.SelectedIndexChanged += new System.EventHandler(this.Handler_GDPListBoxSelectedIndexChanged);
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
            this.wellCityListBox.SelectedIndexChanged += new System.EventHandler(this.Handler_WellCityListBox_SelectedIndexChanged);
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
            this.label4.Location = new System.Drawing.Point(352, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selected Item Index";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selected Item Name";
            // 
            // gdpIndex
            // 
            this.gdpIndex.Location = new System.Drawing.Point(27, 270);
            this.gdpIndex.Name = "gdpIndex";
            this.gdpIndex.Size = new System.Drawing.Size(134, 21);
            this.gdpIndex.TabIndex = 8;
            // 
            // gdpCityName
            // 
            this.gdpCityName.Location = new System.Drawing.Point(28, 304);
            this.gdpCityName.Name = "gdpCityName";
            this.gdpCityName.Size = new System.Drawing.Size(134, 21);
            this.gdpCityName.TabIndex = 9;
            // 
            // wellName
            // 
            this.wellName.Location = new System.Drawing.Point(190, 304);
            this.wellName.Name = "wellName";
            this.wellName.Size = new System.Drawing.Size(134, 21);
            this.wellName.TabIndex = 11;
            // 
            // wellIndex
            // 
            this.wellIndex.Location = new System.Drawing.Point(190, 270);
            this.wellIndex.Name = "wellIndex";
            this.wellIndex.Size = new System.Drawing.Size(134, 21);
            this.wellIndex.TabIndex = 10;
            // 
            // favoriteRestaurant
            // 
            this.favoriteRestaurant.Controls.Add(this.result);
            this.favoriteRestaurant.Controls.Add(this.deleteButton);
            this.favoriteRestaurant.Controls.Add(this.addButton);
            this.favoriteRestaurant.Controls.Add(this.restaurantComboBox);
            this.favoriteRestaurant.Controls.Add(this.restaurantList);
            this.favoriteRestaurant.Location = new System.Drawing.Point(507, 26);
            this.favoriteRestaurant.Name = "favoriteRestaurant";
            this.favoriteRestaurant.Size = new System.Drawing.Size(258, 107);
            this.favoriteRestaurant.TabIndex = 12;
            this.favoriteRestaurant.TabStop = false;
            this.favoriteRestaurant.Text = "Chapter 141";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(6, 109);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(136, 71);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.Handler_DeleteButtonClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(136, 42);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Handler_AddButtonClick);
            // 
            // restaurantComboBox
            // 
            this.restaurantComboBox.FormattingEnabled = true;
            this.restaurantComboBox.Items.AddRange(new object[] {
            "식당을 선택해 주세요.",
            "-------------------------",
            "마제신성",
            "우츠",
            "천안문",
            "천리집",
            "부대볶음"});
            this.restaurantComboBox.Location = new System.Drawing.Point(8, 46);
            this.restaurantComboBox.Name = "restaurantComboBox";
            this.restaurantComboBox.Size = new System.Drawing.Size(121, 20);
            this.restaurantComboBox.TabIndex = 14;
            this.restaurantComboBox.SelectedIndexChanged += new System.EventHandler(this.Handler_ComboBox1SelectedIndexChanged);
            // 
            // restaurantList
            // 
            this.restaurantList.AutoSize = true;
            this.restaurantList.Location = new System.Drawing.Point(6, 31);
            this.restaurantList.Name = "restaurantList";
            this.restaurantList.Size = new System.Drawing.Size(121, 12);
            this.restaurantList.TabIndex = 13;
            this.restaurantList.Text = "좋아하는 식당 리스트";
            // 
            // groupBox142
            // 
            this.groupBox142.Controls.Add(this.checkedItems);
            this.groupBox142.Controls.Add(this.allMoveRight);
            this.groupBox142.Controls.Add(this.checkedListBox1);
            this.groupBox142.Controls.Add(this.label6);
            this.groupBox142.Controls.Add(this.moveLeft);
            this.groupBox142.Controls.Add(this.moveRight);
            this.groupBox142.Location = new System.Drawing.Point(507, 150);
            this.groupBox142.Name = "groupBox142";
            this.groupBox142.Size = new System.Drawing.Size(324, 168);
            this.groupBox142.TabIndex = 18;
            this.groupBox142.TabStop = false;
            this.groupBox142.Text = "Chapter 142";
            // 
            // checkedItems
            // 
            this.checkedItems.FormattingEnabled = true;
            this.checkedItems.ItemHeight = 12;
            this.checkedItems.Location = new System.Drawing.Point(195, 15);
            this.checkedItems.Name = "checkedItems";
            this.checkedItems.Size = new System.Drawing.Size(120, 136);
            this.checkedItems.TabIndex = 20;
            // 
            // allMoveRight
            // 
            this.allMoveRight.Location = new System.Drawing.Point(137, 69);
            this.allMoveRight.Name = "allMoveRight";
            this.allMoveRight.Size = new System.Drawing.Size(41, 23);
            this.allMoveRight.TabIndex = 19;
            this.allMoveRight.Text = ">>";
            this.allMoveRight.UseVisualStyleBackColor = true;
            this.allMoveRight.Click += new System.EventHandler(this.Handler_AllMoveRightClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(9, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 132);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.Handler_CheckedListBox1SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 17;
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(137, 104);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(41, 23);
            this.moveLeft.TabIndex = 16;
            this.moveLeft.Text = "<";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.Handler_MoveLeftClick);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(137, 37);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(41, 23);
            this.moveRight.TabIndex = 15;
            this.moveRight.Text = ">";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.Handler_MoveRightClick);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 154);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(29, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 180);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chapter 144";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox142);
            this.Controls.Add(this.favoriteRestaurant);
            this.Controls.Add(this.wellName);
            this.Controls.Add(this.wellIndex);
            this.Controls.Add(this.gdpCityName);
            this.Controls.Add(this.gdpIndex);
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
            this.favoriteRestaurant.ResumeLayout(false);
            this.favoriteRestaurant.PerformLayout();
            this.groupBox142.ResumeLayout(false);
            this.groupBox142.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox gdpIndex;
        private System.Windows.Forms.TextBox gdpCityName;
        private System.Windows.Forms.TextBox wellName;
        private System.Windows.Forms.TextBox wellIndex;
        private System.Windows.Forms.GroupBox favoriteRestaurant;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox restaurantComboBox;
        private System.Windows.Forms.Label restaurantList;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.GroupBox groupBox142;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.ListBox checkedItems;
        private System.Windows.Forms.Button allMoveRight;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
    }
}