namespace _05_ComboBox_CheckedList_Link_MaskedTxtBox
{
    partial class frm2
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
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteLastItem = new System.Windows.Forms.Button();
            this.tbNewItem = new System.Windows.Forms.TextBox();
            this.btnShowList = new System.Windows.Forms.Button();
            this.tbSeletedItem = new System.Windows.Forms.TextBox();
            this.lbSeletedItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbItems
            // 
            this.cbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"});
            this.cbItems.Location = new System.Drawing.Point(299, 43);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 0;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteLastItem
            // 
            this.btnDeleteLastItem.Location = new System.Drawing.Point(299, 137);
            this.btnDeleteLastItem.Name = "btnDeleteLastItem";
            this.btnDeleteLastItem.Size = new System.Drawing.Size(100, 31);
            this.btnDeleteLastItem.TabIndex = 2;
            this.btnDeleteLastItem.Text = "Delete Last";
            this.btnDeleteLastItem.UseVisualStyleBackColor = true;
            this.btnDeleteLastItem.Click += new System.EventHandler(this.btnDeleteLastItem_Click);
            // 
            // tbNewItem
            // 
            this.tbNewItem.Location = new System.Drawing.Point(138, 99);
            this.tbNewItem.Name = "tbNewItem";
            this.tbNewItem.Size = new System.Drawing.Size(100, 20);
            this.tbNewItem.TabIndex = 3;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(460, 137);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(100, 31);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // tbSeletedItem
            // 
            this.tbSeletedItem.Location = new System.Drawing.Point(299, 99);
            this.tbSeletedItem.Name = "tbSeletedItem";
            this.tbSeletedItem.Size = new System.Drawing.Size(100, 20);
            this.tbSeletedItem.TabIndex = 5;
            // 
            // lbSeletedItem
            // 
            this.lbSeletedItem.AutoSize = true;
            this.lbSeletedItem.Location = new System.Drawing.Point(296, 83);
            this.lbSeletedItem.Name = "lbSeletedItem";
            this.lbSeletedItem.Size = new System.Drawing.Size(66, 13);
            this.lbSeletedItem.TabIndex = 6;
            this.lbSeletedItem.Text = "Seleted Item";
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSeletedItem);
            this.Controls.Add(this.tbSeletedItem);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.tbNewItem);
            this.Controls.Add(this.btnDeleteLastItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbItems);
            this.Name = "frm2";
            this.Text = "Form2 Combo Box";
            this.Load += new System.EventHandler(this.frm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteLastItem;
        private System.Windows.Forms.TextBox tbNewItem;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.TextBox tbSeletedItem;
        private System.Windows.Forms.Label lbSeletedItem;
    }
}