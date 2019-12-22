namespace Charles_Hotel_2017101992
{
    partial class CheckOutRoomForm_2017101992
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
            this.printBtn = new System.Windows.Forms.Button();
            this.SomethingBox = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.ciMoneyBox = new System.Windows.Forms.TextBox();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.HouseNumberBox = new System.Windows.Forms.ComboBox();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AccountMoneyBox = new System.Windows.Forms.TextBox();
            this.TotalMoneyBox = new System.Windows.Forms.TextBox();
            this.riaMoneyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.printBtn);
            this.groupBox1.Controls.Add(this.SomethingBox);
            this.groupBox1.Controls.Add(this.TextName);
            this.groupBox1.Controls.Add(this.ciMoneyBox);
            this.groupBox1.Controls.Add(this.dtpIn);
            this.groupBox1.Controls.Add(this.HouseNumberBox);
            this.groupBox1.Controls.Add(this.dtpOut);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "旅客信息登记";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(349, 360);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 15;
            this.printBtn.Text = "导出";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // SomethingBox
            // 
            this.SomethingBox.Location = new System.Drawing.Point(474, 203);
            this.SomethingBox.Multiline = true;
            this.SomethingBox.Name = "SomethingBox";
            this.SomethingBox.Size = new System.Drawing.Size(200, 121);
            this.SomethingBox.TabIndex = 14;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(120, 96);
            this.TextName.Name = "TextName";
            this.TextName.ReadOnly = true;
            this.TextName.Size = new System.Drawing.Size(100, 25);
            this.TextName.TabIndex = 13;
            // 
            // ciMoneyBox
            // 
            this.ciMoneyBox.Location = new System.Drawing.Point(474, 140);
            this.ciMoneyBox.Name = "ciMoneyBox";
            this.ciMoneyBox.ReadOnly = true;
            this.ciMoneyBox.Size = new System.Drawing.Size(200, 25);
            this.ciMoneyBox.TabIndex = 12;
            // 
            // dtpIn
            // 
            this.dtpIn.Location = new System.Drawing.Point(474, 92);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(200, 25);
            this.dtpIn.TabIndex = 11;
            // 
            // HouseNumberBox
            // 
            this.HouseNumberBox.FormattingEnabled = true;
            this.HouseNumberBox.Location = new System.Drawing.Point(474, 54);
            this.HouseNumberBox.Name = "HouseNumberBox";
            this.HouseNumberBox.Size = new System.Drawing.Size(121, 23);
            this.HouseNumberBox.TabIndex = 10;
            this.HouseNumberBox.SelectedIndexChanged += new System.EventHandler(this.HouseNumberBox_SelectedIndexChanged);
            // 
            // dtpOut
            // 
            this.dtpOut.Location = new System.Drawing.Point(120, 47);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(200, 25);
            this.dtpOut.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "备注";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "折合价格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "入住日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "房号";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(584, 360);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(90, 29);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "重置";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(42, 358);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(99, 33);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AccountMoneyBox);
            this.groupBox2.Controls.Add(this.TotalMoneyBox);
            this.groupBox2.Controls.Add(this.riaMoneyBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(50, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "费用结算";
            // 
            // AccountMoneyBox
            // 
            this.AccountMoneyBox.Location = new System.Drawing.Point(96, 144);
            this.AccountMoneyBox.Name = "AccountMoneyBox";
            this.AccountMoneyBox.ReadOnly = true;
            this.AccountMoneyBox.Size = new System.Drawing.Size(100, 25);
            this.AccountMoneyBox.TabIndex = 5;
            // 
            // TotalMoneyBox
            // 
            this.TotalMoneyBox.Location = new System.Drawing.Point(96, 89);
            this.TotalMoneyBox.Name = "TotalMoneyBox";
            this.TotalMoneyBox.ReadOnly = true;
            this.TotalMoneyBox.Size = new System.Drawing.Size(100, 25);
            this.TotalMoneyBox.TabIndex = 4;
            // 
            // riaMoneyBox
            // 
            this.riaMoneyBox.Location = new System.Drawing.Point(96, 36);
            this.riaMoneyBox.Name = "riaMoneyBox";
            this.riaMoneyBox.ReadOnly = true;
            this.riaMoneyBox.Size = new System.Drawing.Size(100, 25);
            this.riaMoneyBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "结账金额";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "费用总额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "预收押金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "旅客姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = " 结账日期";
            // 
            // CheckOutRoomForm_2017101992
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckOutRoomForm_2017101992";
            this.Load += new System.EventHandler(this.CheckOutRoomForm_2017101992_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox ciMoneyBox;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.ComboBox HouseNumberBox;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TotalMoneyBox;
        private System.Windows.Forms.TextBox riaMoneyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SomethingBox;
        private System.Windows.Forms.TextBox AccountMoneyBox;
        private System.Windows.Forms.Button printBtn;
    }
}