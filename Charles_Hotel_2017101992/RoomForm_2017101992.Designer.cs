namespace Charles_Hotel_2017101992
{
    partial class RoomForm_2017101992
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomGridView = new System.Windows.Forms.DataGridView();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.hotelDataSet = new Charles_Hotel_2017101992.HotelDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Charles_Hotel_2017101992.HotelDataSetTableAdapters.RoomTableAdapter();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerRoomTableAdapter = new Charles_Hotel_2017101992.HotelDataSetTableAdapters.RegisterRoomTableAdapter();
            this.inIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foregiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delMarkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomGridView);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入住情况";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientGridView);
            this.groupBox2.Location = new System.Drawing.Point(17, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "旅客信息";
            // 
            // roomGridView
            // 
            this.roomGridView.AllowUserToAddRows = false;
            this.roomGridView.AllowUserToDeleteRows = false;
            this.roomGridView.AutoGenerateColumns = false;
            this.roomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.roomFloorDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.personNumDataGridViewTextBoxColumn,
            this.inPersonDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.roomGridView.DataSource = this.roomBindingSource;
            this.roomGridView.Location = new System.Drawing.Point(6, 24);
            this.roomGridView.MultiSelect = false;
            this.roomGridView.Name = "roomGridView";
            this.roomGridView.ReadOnly = true;
            this.roomGridView.RowTemplate.Height = 27;
            this.roomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomGridView.Size = new System.Drawing.Size(761, 183);
            this.roomGridView.TabIndex = 0;
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
            this.roomIdDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.foregiftDataGridViewTextBoxColumn,
            this.inTimeDataGridViewTextBoxColumn,
            this.outTimeDataGridViewTextBoxColumn,
            this.sexDataGridViewCheckBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.certTypeDataGridViewTextBoxColumn,
            this.certIdDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.personNumDataGridViewTextBoxColumn1,
            this.operDataGridViewTextBoxColumn,
            this.delMarkDataGridViewCheckBoxColumn});
            this.clientGridView.DataSource = this.registerRoomBindingSource;
            this.clientGridView.Location = new System.Drawing.Point(6, 24);
            this.clientGridView.MultiSelect = false;
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.ReadOnly = true;
            this.clientGridView.RowTemplate.Height = 27;
            this.clientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientGridView.Size = new System.Drawing.Size(759, 186);
            this.clientGridView.TabIndex = 0;
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "房间编号";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "roomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "房间类型";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomFloorDataGridViewTextBoxColumn
            // 
            this.roomFloorDataGridViewTextBoxColumn.DataPropertyName = "roomFloor";
            this.roomFloorDataGridViewTextBoxColumn.HeaderText = "楼层";
            this.roomFloorDataGridViewTextBoxColumn.Name = "roomFloorDataGridViewTextBoxColumn";
            this.roomFloorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personNumDataGridViewTextBoxColumn
            // 
            this.personNumDataGridViewTextBoxColumn.DataPropertyName = "personNum";
            this.personNumDataGridViewTextBoxColumn.HeaderText = "容纳人数";
            this.personNumDataGridViewTextBoxColumn.Name = "personNumDataGridViewTextBoxColumn";
            this.personNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inPersonDataGridViewTextBoxColumn
            // 
            this.inPersonDataGridViewTextBoxColumn.DataPropertyName = "inPerson";
            this.inPersonDataGridViewTextBoxColumn.HeaderText = "已入住人数";
            this.inPersonDataGridViewTextBoxColumn.Name = "inPersonDataGridViewTextBoxColumn";
            this.inPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerRoomBindingSource
            // 
            this.registerRoomBindingSource.DataMember = "RegisterRoom";
            this.registerRoomBindingSource.DataSource = this.hotelDataSet;
            // 
            // registerRoomTableAdapter
            // 
            this.registerRoomTableAdapter.ClearBeforeFill = true;
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
            // roomIdDataGridViewTextBoxColumn1
            // 
            this.roomIdDataGridViewTextBoxColumn1.DataPropertyName = "roomId";
            this.roomIdDataGridViewTextBoxColumn1.HeaderText = "房间号";
            this.roomIdDataGridViewTextBoxColumn1.Name = "roomIdDataGridViewTextBoxColumn1";
            this.roomIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // personNumDataGridViewTextBoxColumn1
            // 
            this.personNumDataGridViewTextBoxColumn1.DataPropertyName = "personNum";
            this.personNumDataGridViewTextBoxColumn1.HeaderText = "入住人数";
            this.personNumDataGridViewTextBoxColumn1.Name = "personNumDataGridViewTextBoxColumn1";
            this.personNumDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // RoomForm_2017101992
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomForm_2017101992";
            this.Text = "客房信息查询";
            this.Load += new System.EventHandler(this.RoomForm_2017101992_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRoomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView roomGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView clientGridView;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomFloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource registerRoomBindingSource;
        private HotelDataSetTableAdapters.RegisterRoomTableAdapter registerRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn foregiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sexDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delMarkDataGridViewCheckBoxColumn;
    }
}