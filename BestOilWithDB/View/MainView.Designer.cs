
namespace BestOilWithDB.View
{
    partial class MainView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.aznRadiobtn = new System.Windows.Forms.RadioButton();
            this.litrRadiobtn = new System.Windows.Forms.RadioButton();
            this.aznLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.Minikafegroupbox = new System.Windows.Forms.GroupBox();
            this.colocount = new System.Windows.Forms.TextBox();
            this.Freecount = new System.Windows.Forms.TextBox();
            this.HhamburgerCount = new System.Windows.Forms.TextBox();
            this.HotDogCount = new System.Windows.Forms.TextBox();
            this.CafeTotal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CafeTotalLabel = new System.Windows.Forms.Label();
            this.colatxtbox = new System.Windows.Forms.TextBox();
            this.Freetxtbox = new System.Windows.Forms.TextBox();
            this.Hamburgertxtbox = new System.Windows.Forms.TextBox();
            this.HotDogTextBox = new System.Windows.Forms.TextBox();
            this.CocoColacheckbox = new System.Windows.Forms.CheckBox();
            this.kartofFreecheckbox = new System.Windows.Forms.CheckBox();
            this.Hamburgercheckboc = new System.Windows.Forms.CheckBox();
            this.HotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalLabelOilAndCafe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Minikafegroupbox.SuspendLayout();
            this.CafeTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalLbl);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.aznRadiobtn);
            this.groupBox1.Controls.Add(this.litrRadiobtn);
            this.groupBox1.Controls.Add(this.aznLbl);
            this.groupBox1.Controls.Add(this.priceLbl);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.cv);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gasoline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "AZN";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(97, 309);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(24, 25);
            this.totalLbl.TabIndex = 9;
            this.totalLbl.Text = "0";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(128, 231);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox2.TabIndex = 8;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(128, 178);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // aznRadiobtn
            // 
            this.aznRadiobtn.AutoSize = true;
            this.aznRadiobtn.Location = new System.Drawing.Point(11, 233);
            this.aznRadiobtn.Name = "aznRadiobtn";
            this.aznRadiobtn.Size = new System.Drawing.Size(72, 29);
            this.aznRadiobtn.TabIndex = 6;
            this.aznRadiobtn.TabStop = true;
            this.aznRadiobtn.Text = "AZN";
            this.aznRadiobtn.UseVisualStyleBackColor = true;
            this.aznRadiobtn.CheckedChanged += new System.EventHandler(this.aznRadiobtn_CheckedChanged);
            // 
            // litrRadiobtn
            // 
            this.litrRadiobtn.AutoSize = true;
            this.litrRadiobtn.Location = new System.Drawing.Point(11, 178);
            this.litrRadiobtn.Name = "litrRadiobtn";
            this.litrRadiobtn.Size = new System.Drawing.Size(60, 29);
            this.litrRadiobtn.TabIndex = 5;
            this.litrRadiobtn.TabStop = true;
            this.litrRadiobtn.Text = "Litr";
            this.litrRadiobtn.UseVisualStyleBackColor = true;
            this.litrRadiobtn.CheckedChanged += new System.EventHandler(this.litrRadiobtn_CheckedChanged);
            // 
            // aznLbl
            // 
            this.aznLbl.AutoSize = true;
            this.aznLbl.Location = new System.Drawing.Point(187, 128);
            this.aznLbl.Name = "aznLbl";
            this.aznLbl.Size = new System.Drawing.Size(54, 25);
            this.aznLbl.TabIndex = 4;
            this.aznLbl.Text = "AZN";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(90, 128);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(24, 25);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "0";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 128);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 25);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(6, 52);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(38, 25);
            this.cv.TabIndex = 1;
            this.cv.Text = "Oil";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.Silver;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBtn.Location = new System.Drawing.Point(43, 475);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(719, 75);
            this.CalculateBtn.TabIndex = 1;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(291, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 342);
            this.listBox1.TabIndex = 2;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Silver;
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadBtn.Location = new System.Drawing.Point(291, 384);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(223, 37);
            this.LoadBtn.TabIndex = 3;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Minikafegroupbox
            // 
            this.Minikafegroupbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Minikafegroupbox.Controls.Add(this.colocount);
            this.Minikafegroupbox.Controls.Add(this.Freecount);
            this.Minikafegroupbox.Controls.Add(this.HhamburgerCount);
            this.Minikafegroupbox.Controls.Add(this.HotDogCount);
            this.Minikafegroupbox.Controls.Add(this.CafeTotal);
            this.Minikafegroupbox.Controls.Add(this.colatxtbox);
            this.Minikafegroupbox.Controls.Add(this.Freetxtbox);
            this.Minikafegroupbox.Controls.Add(this.Hamburgertxtbox);
            this.Minikafegroupbox.Controls.Add(this.HotDogTextBox);
            this.Minikafegroupbox.Controls.Add(this.CocoColacheckbox);
            this.Minikafegroupbox.Controls.Add(this.kartofFreecheckbox);
            this.Minikafegroupbox.Controls.Add(this.Hamburgercheckboc);
            this.Minikafegroupbox.Controls.Add(this.HotDogCheckBox);
            this.Minikafegroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minikafegroupbox.Location = new System.Drawing.Point(530, 20);
            this.Minikafegroupbox.Name = "Minikafegroupbox";
            this.Minikafegroupbox.Size = new System.Drawing.Size(277, 346);
            this.Minikafegroupbox.TabIndex = 4;
            this.Minikafegroupbox.TabStop = false;
            this.Minikafegroupbox.Text = "Mini-Kafe";
            // 
            // colocount
            // 
            this.colocount.Enabled = false;
            this.colocount.Location = new System.Drawing.Point(210, 136);
            this.colocount.Multiline = true;
            this.colocount.Name = "colocount";
            this.colocount.Size = new System.Drawing.Size(61, 20);
            this.colocount.TabIndex = 12;
            // 
            // Freecount
            // 
            this.Freecount.Enabled = false;
            this.Freecount.Location = new System.Drawing.Point(210, 109);
            this.Freecount.Multiline = true;
            this.Freecount.Name = "Freecount";
            this.Freecount.Size = new System.Drawing.Size(61, 20);
            this.Freecount.TabIndex = 11;
            // 
            // HhamburgerCount
            // 
            this.HhamburgerCount.Enabled = false;
            this.HhamburgerCount.Location = new System.Drawing.Point(210, 76);
            this.HhamburgerCount.Multiline = true;
            this.HhamburgerCount.Name = "HhamburgerCount";
            this.HhamburgerCount.Size = new System.Drawing.Size(61, 20);
            this.HhamburgerCount.TabIndex = 10;
            // 
            // HotDogCount
            // 
            this.HotDogCount.Enabled = false;
            this.HotDogCount.Location = new System.Drawing.Point(210, 41);
            this.HotDogCount.Multiline = true;
            this.HotDogCount.Name = "HotDogCount";
            this.HotDogCount.Size = new System.Drawing.Size(61, 20);
            this.HotDogCount.TabIndex = 9;
            // 
            // CafeTotal
            // 
            this.CafeTotal.Controls.Add(this.label3);
            this.CafeTotal.Controls.Add(this.CafeTotalLabel);
            this.CafeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CafeTotal.Location = new System.Drawing.Point(6, 255);
            this.CafeTotal.Name = "CafeTotal";
            this.CafeTotal.Size = new System.Drawing.Size(265, 85);
            this.CafeTotal.TabIndex = 8;
            this.CafeTotal.TabStop = false;
            this.CafeTotal.Text = "CafeTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Azn";
            // 
            // CafeTotalLabel
            // 
            this.CafeTotalLabel.AutoSize = true;
            this.CafeTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CafeTotalLabel.Location = new System.Drawing.Point(169, 32);
            this.CafeTotalLabel.Name = "CafeTotalLabel";
            this.CafeTotalLabel.Size = new System.Drawing.Size(26, 29);
            this.CafeTotalLabel.TabIndex = 2;
            this.CafeTotalLabel.Text = "0";
            // 
            // colatxtbox
            // 
            this.colatxtbox.Enabled = false;
            this.colatxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colatxtbox.Location = new System.Drawing.Point(136, 136);
            this.colatxtbox.Multiline = true;
            this.colatxtbox.Name = "colatxtbox";
            this.colatxtbox.Size = new System.Drawing.Size(61, 20);
            this.colatxtbox.TabIndex = 7;
            // 
            // Freetxtbox
            // 
            this.Freetxtbox.Enabled = false;
            this.Freetxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freetxtbox.Location = new System.Drawing.Point(136, 108);
            this.Freetxtbox.Multiline = true;
            this.Freetxtbox.Name = "Freetxtbox";
            this.Freetxtbox.Size = new System.Drawing.Size(61, 20);
            this.Freetxtbox.TabIndex = 6;
            // 
            // Hamburgertxtbox
            // 
            this.Hamburgertxtbox.Enabled = false;
            this.Hamburgertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hamburgertxtbox.Location = new System.Drawing.Point(136, 76);
            this.Hamburgertxtbox.Multiline = true;
            this.Hamburgertxtbox.Name = "Hamburgertxtbox";
            this.Hamburgertxtbox.Size = new System.Drawing.Size(61, 20);
            this.Hamburgertxtbox.TabIndex = 5;
            this.Hamburgertxtbox.TextChanged += new System.EventHandler(this.Hamburgertxtbox_TextChanged);
            // 
            // HotDogTextBox
            // 
            this.HotDogTextBox.Enabled = false;
            this.HotDogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDogTextBox.Location = new System.Drawing.Point(136, 41);
            this.HotDogTextBox.Multiline = true;
            this.HotDogTextBox.Name = "HotDogTextBox";
            this.HotDogTextBox.Size = new System.Drawing.Size(61, 20);
            this.HotDogTextBox.TabIndex = 4;
            // 
            // CocoColacheckbox
            // 
            this.CocoColacheckbox.AutoSize = true;
            this.CocoColacheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CocoColacheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CocoColacheckbox.Location = new System.Drawing.Point(21, 135);
            this.CocoColacheckbox.Name = "CocoColacheckbox";
            this.CocoColacheckbox.Size = new System.Drawing.Size(97, 21);
            this.CocoColacheckbox.TabIndex = 3;
            this.CocoColacheckbox.Text = "Coco-Cola";
            this.CocoColacheckbox.UseVisualStyleBackColor = false;
            this.CocoColacheckbox.CheckedChanged += new System.EventHandler(this.CocoColacheckbox_CheckedChanged);
            // 
            // kartofFreecheckbox
            // 
            this.kartofFreecheckbox.AutoSize = true;
            this.kartofFreecheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kartofFreecheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kartofFreecheckbox.Location = new System.Drawing.Point(21, 108);
            this.kartofFreecheckbox.Name = "kartofFreecheckbox";
            this.kartofFreecheckbox.Size = new System.Drawing.Size(99, 21);
            this.kartofFreecheckbox.TabIndex = 2;
            this.kartofFreecheckbox.Text = "Kartof-Free";
            this.kartofFreecheckbox.UseVisualStyleBackColor = false;
            this.kartofFreecheckbox.CheckedChanged += new System.EventHandler(this.kartofFreecheckbox_CheckedChanged);
            // 
            // Hamburgercheckboc
            // 
            this.Hamburgercheckboc.AutoSize = true;
            this.Hamburgercheckboc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Hamburgercheckboc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hamburgercheckboc.Location = new System.Drawing.Point(21, 76);
            this.Hamburgercheckboc.Name = "Hamburgercheckboc";
            this.Hamburgercheckboc.Size = new System.Drawing.Size(101, 21);
            this.Hamburgercheckboc.TabIndex = 1;
            this.Hamburgercheckboc.Text = "Hamburger";
            this.Hamburgercheckboc.UseVisualStyleBackColor = false;
            this.Hamburgercheckboc.CheckedChanged += new System.EventHandler(this.Hamburgercheckboc_CheckedChanged);
            // 
            // HotDogCheckBox
            // 
            this.HotDogCheckBox.AutoSize = true;
            this.HotDogCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HotDogCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDogCheckBox.Location = new System.Drawing.Point(21, 40);
            this.HotDogCheckBox.Name = "HotDogCheckBox";
            this.HotDogCheckBox.Size = new System.Drawing.Size(84, 21);
            this.HotDogCheckBox.TabIndex = 0;
            this.HotDogCheckBox.Text = "Hot-Dog";
            this.HotDogCheckBox.UseVisualStyleBackColor = false;
            this.HotDogCheckBox.CheckedChanged += new System.EventHandler(this.HotDogCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Azn";
            // 
            // TotalLabelOilAndCafe
            // 
            this.TotalLabelOilAndCafe.AutoSize = true;
            this.TotalLabelOilAndCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabelOilAndCafe.Location = new System.Drawing.Point(641, 414);
            this.TotalLabelOilAndCafe.Name = "TotalLabelOilAndCafe";
            this.TotalLabelOilAndCafe.Size = new System.Drawing.Size(26, 29);
            this.TotalLabelOilAndCafe.TabIndex = 6;
            this.TotalLabelOilAndCafe.Text = "0";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(819, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalLabelOilAndCafe);
            this.Controls.Add(this.Minikafegroupbox);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Minikafegroupbox.ResumeLayout(false);
            this.Minikafegroupbox.PerformLayout();
            this.CafeTotal.ResumeLayout(false);
            this.CafeTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton aznRadiobtn;
        private System.Windows.Forms.RadioButton litrRadiobtn;
        private System.Windows.Forms.Label aznLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.GroupBox Minikafegroupbox;
        private System.Windows.Forms.TextBox colocount;
        private System.Windows.Forms.TextBox Freecount;
        private System.Windows.Forms.TextBox HhamburgerCount;
        private System.Windows.Forms.TextBox HotDogCount;
        private System.Windows.Forms.GroupBox CafeTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CafeTotalLabel;
        private System.Windows.Forms.TextBox colatxtbox;
        private System.Windows.Forms.TextBox Freetxtbox;
        private System.Windows.Forms.TextBox Hamburgertxtbox;
        private System.Windows.Forms.TextBox HotDogTextBox;
        private System.Windows.Forms.CheckBox CocoColacheckbox;
        private System.Windows.Forms.CheckBox kartofFreecheckbox;
        private System.Windows.Forms.CheckBox Hamburgercheckboc;
        private System.Windows.Forms.CheckBox HotDogCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalLabelOilAndCafe;
    }
}