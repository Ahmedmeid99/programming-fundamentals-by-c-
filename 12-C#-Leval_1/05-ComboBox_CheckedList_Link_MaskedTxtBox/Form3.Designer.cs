namespace _05_ComboBox_CheckedList_Link_MaskedTxtBox
{
    partial class frm3
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
            this.cbCardItems = new System.Windows.Forms.CheckedListBox();
            this.tbAddNewItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.tbSelectItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbCardItems
            // 
            this.cbCardItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbCardItems.CheckOnClick = true;
            this.cbCardItems.FormattingEnabled = true;
            this.cbCardItems.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"});
            this.cbCardItems.Location = new System.Drawing.Point(452, 44);
            this.cbCardItems.Name = "cbCardItems";
            this.cbCardItems.Size = new System.Drawing.Size(120, 90);
            this.cbCardItems.TabIndex = 0;
            this.cbCardItems.SelectedIndexChanged += new System.EventHandler(this.cbCardItems_SelectedIndexChanged);
            // 
            // tbAddNewItem
            // 
            this.tbAddNewItem.Location = new System.Drawing.Point(302, 57);
            this.tbAddNewItem.Name = "tbAddNewItem";
            this.tbAddNewItem.Size = new System.Drawing.Size(120, 20);
            this.tbAddNewItem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New Item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(302, 94);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count ";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(509, 28);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 13);
            this.lbCount.TabIndex = 6;
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Location = new System.Drawing.Point(452, 161);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(120, 23);
            this.btnSelectItem.TabIndex = 7;
            this.btnSelectItem.Text = "select Index";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // tbSelectItem
            // 
            this.tbSelectItem.Location = new System.Drawing.Point(452, 135);
            this.tbSelectItem.Name = "tbSelectItem";
            this.tbSelectItem.Size = new System.Drawing.Size(120, 20);
            this.tbSelectItem.TabIndex = 8;
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSelectItem);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddNewItem);
            this.Controls.Add(this.cbCardItems);
            this.Name = "frm3";
            this.Text = "Form3 CheckedList";
            this.Load += new System.EventHandler(this.frm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbCardItems;
        private System.Windows.Forms.TextBox tbAddNewItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.TextBox tbSelectItem;
    }
}