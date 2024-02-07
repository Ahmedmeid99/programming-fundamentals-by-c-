namespace Pizza
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdThinkCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMeduim = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkChees = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatin = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSise = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(306, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdThinkCrust);
            this.groupBox1.Controls.Add(this.rdThinCrust);
            this.groupBox1.Location = new System.Drawing.Point(55, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crust Type";
            // 
            // rdThinkCrust
            // 
            this.rdThinkCrust.AutoSize = true;
            this.rdThinkCrust.Location = new System.Drawing.Point(35, 70);
            this.rdThinkCrust.Name = "rdThinkCrust";
            this.rdThinkCrust.Size = new System.Drawing.Size(79, 17);
            this.rdThinkCrust.TabIndex = 4;
            this.rdThinkCrust.TabStop = true;
            this.rdThinkCrust.Tag = "10";
            this.rdThinkCrust.Text = "Think Crust";
            this.rdThinkCrust.UseVisualStyleBackColor = true;
            this.rdThinkCrust.CheckedChanged += new System.EventHandler(this.rdThinkCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Location = new System.Drawing.Point(35, 31);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(73, 17);
            this.rdThinCrust.TabIndex = 3;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Tag = "0";
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdLarg);
            this.groupBox2.Controls.Add(this.rdMeduim);
            this.groupBox2.Controls.Add(this.rdSmall);
            this.groupBox2.Location = new System.Drawing.Point(55, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Location = new System.Drawing.Point(35, 93);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(46, 17);
            this.rdLarg.TabIndex = 2;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "40";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // rdMeduim
            // 
            this.rdMeduim.AutoSize = true;
            this.rdMeduim.Location = new System.Drawing.Point(35, 55);
            this.rdMeduim.Name = "rdMeduim";
            this.rdMeduim.Size = new System.Drawing.Size(62, 17);
            this.rdMeduim.TabIndex = 1;
            this.rdMeduim.TabStop = true;
            this.rdMeduim.Tag = "30";
            this.rdMeduim.Text = "Meduim";
            this.rdMeduim.UseVisualStyleBackColor = true;
            this.rdMeduim.CheckedChanged += new System.EventHandler(this.rdMeduim_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(35, 19);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(50, 17);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "20";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkGreenPeppers);
            this.groupBox3.Controls.Add(this.chkTomatoes);
            this.groupBox3.Controls.Add(this.chkOnion);
            this.groupBox3.Controls.Add(this.chkOlives);
            this.groupBox3.Controls.Add(this.chkMushrooms);
            this.groupBox3.Controls.Add(this.chkChees);
            this.groupBox3.Location = new System.Drawing.Point(331, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(143, 66);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppres";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(6, 66);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(143, 20);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(143, 43);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 2;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 43);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkChees
            // 
            this.chkChees.AutoSize = true;
            this.chkChees.Location = new System.Drawing.Point(6, 20);
            this.chkChees.Name = "chkChees";
            this.chkChees.Size = new System.Drawing.Size(83, 17);
            this.chkChees.TabIndex = 0;
            this.chkChees.Tag = "5";
            this.chkChees.Text = "Extra Chees";
            this.chkChees.UseVisualStyleBackColor = true;
            this.chkChees.CheckedChanged += new System.EventHandler(this.chkChees_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdTakeOut);
            this.groupBox4.Controls.Add(this.rdEatin);
            this.groupBox4.Location = new System.Drawing.Point(331, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where to Eat";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Location = new System.Drawing.Point(111, 27);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(67, 17);
            this.rdTakeOut.TabIndex = 5;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "TakeOut";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // rdEatin
            // 
            this.rdEatin.AutoSize = true;
            this.rdEatin.Location = new System.Drawing.Point(6, 27);
            this.rdEatin.Name = "rdEatin";
            this.rdEatin.Size = new System.Drawing.Size(53, 17);
            this.rdEatin.TabIndex = 4;
            this.rdEatin.TabStop = true;
            this.rdEatin.Text = "Eat In";
            this.rdEatin.UseVisualStyleBackColor = true;
            this.rdEatin.CheckedChanged += new System.EventHandler(this.rdEatin_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.White;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Location = new System.Drawing.Point(331, 354);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(75, 23);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.White;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Location = new System.Drawing.Point(502, 354);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 5;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbTotalPrice);
            this.groupBox5.Controls.Add(this.lbWhereToEat);
            this.groupBox5.Controls.Add(this.lbCrustType);
            this.groupBox5.Controls.Add(this.lbToppings);
            this.groupBox5.Controls.Add(this.lbSise);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(642, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 285);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summary";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbTotalPrice.Location = new System.Drawing.Point(109, 225);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(36, 37);
            this.lbTotalPrice.TabIndex = 16;
            this.lbTotalPrice.Text = "$";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(135, 156);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(76, 15);
            this.lbWhereToEat.TabIndex = 15;
            this.lbWhereToEat.Text = "Where to eat";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(124, 124);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(61, 15);
            this.lbCrustType.TabIndex = 14;
            this.lbCrustType.Text = "CrustType";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoEllipsis = true;
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(76, 72);
            this.lbToppings.MaximumSize = new System.Drawing.Size(140, 50);
            this.lbToppings.MinimumSize = new System.Drawing.Size(140, 50);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(140, 50);
            this.lbToppings.TabIndex = 13;
            this.lbToppings.Text = "Toppings";
            // 
            // lbSise
            // 
            this.lbSise.AutoSize = true;
            this.lbSise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSise.Location = new System.Drawing.Point(76, 32);
            this.lbSise.Name = "lbSise";
            this.lbSise.Size = new System.Drawing.Size(29, 15);
            this.lbSise.TabIndex = 12;
            this.lbSise.Text = "size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Where to Eat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toppings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 455);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMeduim;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdThinkCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.CheckBox chkChees;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatin;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbToppings;
    }
}

