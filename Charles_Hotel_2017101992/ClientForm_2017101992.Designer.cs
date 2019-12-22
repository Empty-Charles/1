namespace Charles_Hotel_2017101992
{
    partial class ClientForm_2017101992
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
            this.components = new System.ComponentModel.Container();
            this.textQueryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.inIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foregiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delMarkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registerRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Charles_Hotel_2017101992.HotelDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textClientName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.cmbCerType = new System.Windows.Forms.ComboBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textCerId = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPersonNum = new System.Windows.Forms.TextBox();
            this.registerRoomTableAdapter = new Charles_Hotel_2017101992.HotelDataSetTableAdapters.RegisterRoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textQueryName
            // 
            this.textQueryName.Location = new System.Drawing.Point(88, 15);
            this.textQueryName.Name = "textQueryName";
            this.textQueryName.Size = new System.Drawing.Size(100, 25);
            this.textQueryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "旅客姓名";
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(221, 15);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnQuery.TabIndex = 2;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.UseVisualStyleBackColor = true;
            // 
            // clientGridView
            // 
            this.clientGridView.AllowUserToAddRows = false;
            this.clientGridView.AllowUserToDeleteRows = false;
            this.clientGridView.AutoGenerateColumns = false;
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inIdDataGridViewTextBoxColumn,
            this.dientNameDataGridViewTextBoxColumn,
            this.roomIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.foregiftDataGridViewTextBoxColumn,
            this.inTimeDataGridViewTextBoxColumn,
            this.outTimeDataGridViewTextBoxColumn,
            this.sexDataGridViewCheckBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.certTypeDataGridViewTextBoxColumn,
            this.certIdDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.personNumDataGridViewTextBoxColumn,
            this.operDataGridViewTextBoxColumn,
            this.delMarkDataGridViewCheckBoxColumn});
            this.clientGridView.DataSource = this.registerRoomBindingSource;
            this.clientGridView.Location = new System.Drawing.Point(33, 57);
            this.clientGridView.MultiSelect = false;
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.ReadOnly = true;
            this.clientGridView.RowTemplate.Height = 27;
            this.clientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientGridView.Size = new System.Drawing.Size(733, 256);
            this.clientGridView.TabIndex = 3;
            // 
            // inIdDataGridViewTextBoxColumn
            // 
            this.inIdDataGridViewTextBoxColumn.DataPropertyName = "inId";
            this.inIdDataGridViewTextBoxColumn.HeaderText = "inId";
            this.inIdDataGridViewTextBoxColumn.Name = "inIdDataGridViewTextBoxColumn";
            this.inIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dientNameDataGridViewTextBoxColumn
            // 
            this.dientNameDataGridViewTextBoxColumn.DataPropertyName = "dientName";
            this.dientNameDataGridViewTextBoxColumn.HeaderText = "客户姓名";
            this.dientNameDataGridViewTextBoxColumn.Name = "dientNameDataGridViewTextBoxColumn";
            this.dientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "房间号";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foregiftDataGridViewTextBoxColumn
            // 
            this.foregiftDataGridViewTextBoxColumn.DataPropertyName = "foregift";
            this.foregiftDataGridViewTextBoxColumn.HeaderText = "押金";
            this.foregiftDataGridViewTextBoxColumn.Name = "foregiftDataGridViewTextBoxColumn";
            this.foregiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inTimeDataGridViewTextBoxColumn
            // 
            this.inTimeDataGridViewTextBoxColumn.DataPropertyName = "inTime";
            this.inTimeDataGridViewTextBoxColumn.HeaderText = "入住时间";
            this.inTimeDataGridViewTextBoxColumn.Name = "inTimeDataGridViewTextBoxColumn";
            this.inTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outTimeDataGridViewTextBoxColumn
            // 
            this.outTimeDataGridViewTextBoxColumn.DataPropertyName = "outTime";
            this.outTimeDataGridViewTextBoxColumn.HeaderText = "离开时间";
            this.outTimeDataGridViewTextBoxColumn.Name = "outTimeDataGridViewTextBoxColumn";
            this.outTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewCheckBoxColumn
            // 
            this.sexDataGridViewCheckBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewCheckBoxColumn.HeaderText = "性别";
            this.sexDataGridViewCheckBoxColumn.Name = "sexDataGridViewCheckBoxColumn";
            this.sexDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certTypeDataGridViewTextBoxColumn
            // 
            this.certTypeDataGridViewTextBoxColumn.DataPropertyName = "certType";
            this.certTypeDataGridViewTextBoxColumn.HeaderText = "身份类型";
            this.certTypeDataGridViewTextBoxColumn.Name = "certTypeDataGridViewTextBoxColumn";
            this.certTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certIdDataGridViewTextBoxColumn
            // 
            this.certIdDataGridViewTextBoxColumn.DataPropertyName = "certId";
            this.certIdDataGridViewTextBoxColumn.HeaderText = "身份号";
            this.certIdDataGridViewTextBoxColumn.Name = "certIdDataGridViewTextBoxColumn";
            this.certIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personNumDataGridViewTextBoxColumn
            // 
            this.personNumDataGridViewTextBoxColumn.DataPropertyName = "personNum";
            this.personNumDataGridViewTextBoxColumn.HeaderText = "入住人数";
            this.personNumDataGridViewTextBoxColumn.Name = "personNumDataGridViewTextBoxColumn";
            this.personNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operDataGridViewTextBoxColumn
            // 
            this.operDataGridViewTextBoxColumn.DataPropertyName = "Oper";
            this.operDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operDataGridViewTextBoxColumn.Name = "operDataGridViewTextBoxColumn";
            this.operDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delMarkDataGridViewCheckBoxColumn
            // 
            this.delMarkDataGridViewCheckBoxColumn.DataPropertyName = "delMark";
            this.delMarkDataGridViewCheckBoxColumn.HeaderText = "delMark";
            this.delMarkDataGridViewCheckBoxColumn.Name = "delMarkDataGridViewCheckBoxColumn";
            this.delMarkDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // registerRoomBindingSource
            // 
            this.registerRoomBindingSource.DataMember = "RegisterRoom";
            this.registerRoomBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "旅客姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "证件类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "证件地址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "住宿人数";
            // 
            // textClientName
            // 
            this.textClientName.Location = new System.Drawing.Point(103, 325);
            this.textClientName.Name = "textClientName";
            this.textClientName.Size = new System.Drawing.Size(100, 25);
            this.textClientName.TabIndex = 9;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(103, 354);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(43, 19);
            this.rbMale.TabIndex = 10;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(160, 355);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(43, 19);
            this.rbFemale.TabIndex = 11;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "联系电话";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "证件号码";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(691, 418);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // cmbCerType
            // 
            this.cmbCerType.FormattingEnabled = true;
            this.cmbCerType.Items.AddRange(new object[] {
            "居民身份证",
            "军官证",
            "警官证",
            "学生证",
            "工作证"});
            this.cmbCerType.Location = new System.Drawing.Point(103, 375);
            this.cmbCerType.Name = "cmbCerType";
            this.cmbCerType.Size = new System.Drawing.Size(121, 23);
            this.cmbCerType.TabIndex = 15;
            this.cmbCerType.Text = "居民身份证";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(389, 341);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 25);
            this.textPhone.TabIndex = 16;
            // 
            // textCerId
            // 
            this.textCerId.Location = new System.Drawing.Point(389, 372);
            this.textCerId.Name = "textCerId";
            this.textCerId.Size = new System.Drawing.Size(100, 25);
            this.textCerId.TabIndex = 17;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(103, 395);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(582, 25);
            this.textAddress.TabIndex = 18;
            // 
            // textPersonNum
            // 
            this.textPersonNum.Location = new System.Drawing.Point(103, 423);
            this.textPersonNum.Name = "textPersonNum";
            this.textPersonNum.Size = new System.Drawing.Size(100, 25);
            this.textPersonNum.TabIndex = 19;
            // 
            // registerRoomTableAdapter
            // 
            this.registerRoomTableAdapter.ClearBeforeFill = true;
            // 
            // ClientForm_2017101992
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPersonNum);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textCerId);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.cmbCerType);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.textClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientGridView);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQueryName);
            this.Name = "ClientForm_2017101992";
            this.Text = "旅客信息查询";
            this.Load += new System.EventHandler(this.ClientForm_2017101992_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textQueryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.DataGridView clientGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textClientName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox cmbCerType;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textCerId;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPersonNum;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource registerRoomBindingSource;
        private HotelDataSetTableAdapters.RegisterRoomTableAdapter registerRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sexDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delMarkDataGridViewCheckBoxColumn;
    }
}